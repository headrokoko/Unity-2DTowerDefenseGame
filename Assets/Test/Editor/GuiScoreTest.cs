using NUnit.Framework;
using System;
using NSubstitute;


namespace Limone.Test{

	[TestFixture]
	[Category("GuiScore Test")]

	public class GuiScoreTest{

		public IGUIScoreController iscore;
		public GuiScoreController score;

		[SetUp] public void Init(){
			this.iscore = GetScoreMock();
			this.score = GetControllerMock(iscore);
			this.score.scoreController.FormatScore().Returns("score :100");
			this.score.scoreController.GetGameData().Returns(100);
		}

		[TearDown] public void Cleanup(){
		}

		[Test]
		[Category("Score Test")]
		public void ScoreTest(){
			string text = score.GetScoreText(100);
			Assert.That("Score :100",Is.EqualTo(text));
		}

		[Test]
		[Category("Score Range Test")]
		public void ScoreTest([Range(-4,4,1)]int x){
			string text = score.GetScoreText(x);
			Assert.That("Score :" + x.ToString(),Is.EqualTo(text));
		}

		[Test]
		[Category("Score Format Test")]
		public void ScoreFormatTest(){
			string text = iscore.FormatScore();
			Assert.That("Score :100",Is.EqualTo(text));
		}

		[Test]
		[Category("Score Format Test")]
		public void GetGameDataTest(){
			string text = score.GetScoreText(iscore.GetGameData());
			Assert.That("Score :100",Is.EqualTo(text));
		}

		private IGUIScoreController GetScoreMock(){
			return Substitute.For<IGUIScoreController>();
		}

		private GuiScoreController GetControllerMock(IGUIScoreController iscore){
			var score = Substitute.For<GuiScoreController>();
			score.SetGuiScoreController(iscore);
			//status.calcTime().Return(0.0f);
			return score;
		}
	}
}
