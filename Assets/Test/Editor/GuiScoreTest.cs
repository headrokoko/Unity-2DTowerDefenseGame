using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test
{
	[TestFixture]
	[Category ("GuiScore Test")]
	public class GuiScoreTest
	{
		public IGeneralController iscore;
		public GuiScoreController score;

		[SetUp] public void Init()
		{
			this.iscore = GetEffectMock ();
			this.score = GetControllerMock (iscore);
		}

		[TearDown] public void Cleanup()
		{
		}

		[Test]
		[Category ("Score Test")]
		public void ScoreTest() {
			string text = score.GetScoreText (100);
			Assert.That ("Score :100", Is.EqualTo(text));
		}
	
		[Test]
		[Category ("Score Range Test")]
		public void ScoreTest([Range(-4,4,1)]int x) {
			string text = score.GetScoreText(x);
			Assert.That ("Score :" + x.ToString(), Is.EqualTo(text));
		}

		[Test]
		[Category ("Score Format Test")]
		public void ScoreFormatTest() {
			string text = iscore.FormatScore ();
			Assert.That ("Score :100", Is.EqualTo(text));
		}

		[Test]
		[Category ("Score Format Test")]
		public void GetGameDataTest() {
			string text = score.GetScoreText (iscore.GetGameData());
			Assert.That ("Score :100", Is.EqualTo(text));
		}

		private IGeneralController GetEffectMock () {
			return Substitute.For<IGeneralController> ();
		}
		private GuiScoreController GetControllerMock(IGeneralController iscore) {
			var score = Substitute.For<GuiScoreController> ();
			iscore.FormatScore ().Returns ("Score :100");
			iscore.GetGameData ().Returns (100);
			score.SetGuiScoreController (iscore);
			return score;
		}
	}
}
