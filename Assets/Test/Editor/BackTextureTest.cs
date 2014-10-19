using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test{
	
	[TestFixture]
	[Category("Background Texture Test")]
	public class BackgroundTextureTest {
		public IGameDataController Igamedata;
		public GameDataController StartTexture;
		public GameDataController MenuTexture;
		//public GameDataController TradeTexture;
		public GameDataController StageSelectTexture;
		public GameDataController ResultTexture;

		[SetUp] public void Init(){
			this.Igamedata = GetGameDataMock();
			this.StartTexture = GetStartTextureMock(Igamedata);
		}

		[Test]
		[Category("StartTexture Empty check Test")]
		public void GetStartTextureNameTest(){
			string texturename = StartTexture.GetStartTexture(Igamedata.GetStartTextureName());
			Assert.That(string.Empty,Is.Not.EqualTo(texturename));
		}

		[Test]
		[Category("MenuTexture Empty check Test")]
		public void GetMenuTextureNameTest(){
			string texturename = Igamedata.GetMenuTextureName();
			Assert.That(string.Empty,Is.Not.EqualTo(texturename));		
		}

		[Test]
		[Category("StageSelectTexture Empty check Test")]
		public void GetStageSelectTextureNameTest(){
			string texturename = Igamedata.GetStageSelectTextureName();
			Assert.That(string.Empty,Is.Not.EqualTo(texturename));		
		}
		
		[Test]
		[Category("ResultTexture Empty check Test")]
		public void GetResultTextureNameTest(){
			string texturename = Igamedata.GetResultTextureName();
			Assert.That(string.Empty,Is.Not.EqualTo(texturename));		
		}


		private IGameDataController GetGameDataMock(){
			return Substitute.For<IGameDataController>();
		}

		private GameDataController GetStartTextureMock(IGameDataController StartTexture){
			var starttexture = Substitute.For<GameDataController>();
			starttexture.SetGameDataController(StartTexture);

			return starttexture;
		}
	}
}
