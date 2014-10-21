using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test{
	
	[TestFixture]
	[Category("Background Texture Test")]
	public class BackgroundTextureTest {
		public IGameDataController Igamedata;
		public GameDataController gamedata;
		public GameData gdata;

		[SetUp] public void Init(){
			this.Igamedata = GetGameDataMock();
			this.gamedata = GetStartTextureMock(Igamedata);
			this.gamedata.IgamedataController.FormatStartTextureName().Returns("start");
			this.gamedata.IgamedataController.GetStartTextureName().Returns("start");
		}

		[Test]
		[Category("StartTexture Empty check Test")]
		public void GetStartTextureEmptyTest(){
			string texturename = Igamedata.GetStartTextureName().ToString();
			Assert.IsNotEmpty(texturename);
		}

		[Test]
		[Category("MenuTexture Empty check Test")]
		public void GetMenuTextureEmptyTest(){
			string texturename = Igamedata.GetMenuTextureName();
			Assert.That(string.Empty,Is.Not.EqualTo(texturename));		
		}

		[Test]
		[Category("StageSelectTexture Empty check Test")]
		public void GetStageSelectTextureEmptyTest(){
			string texturename = Igamedata.GetStageSelectTextureName();
			Assert.That(string.Empty,Is.Not.EqualTo(texturename));		
		}
		
		[Test]
		[Category("ResultTexture Empty check Test")]
		public void GetResultTextureEmptyTest(){
			string texturename = Igamedata.GetResultTextureName();
			Assert.That(string.Empty,Is.Not.EqualTo(texturename));		
		}


		private IGameDataController GetGameDataMock(){
			return Substitute.For<IGameDataController>();
		}

		private GameDataController GetStartTextureMock(IGameDataController StartTexture){
			var starttexture = Substitute.For<GameDataController>();
			starttexture.SetGameDataController(StartTexture);
			gdata = new GameData();

			return starttexture;
		}
	}
}
