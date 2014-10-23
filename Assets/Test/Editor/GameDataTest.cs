using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test{
	
	[TestFixture]
	[Category("GameData Test")]

	public class GameDataTest{
		public IGameDataController IGameData;
		public GameDataController gamedatacontroller;
		
		[SetUp] public void Init(){
			this.IGameData = GetGameDataMock();
			this.gamedatacontroller = GetGameDataControllerMock(IGameData);
		}

		
		[TearDown] public void Cleanup(){
		}
		[Test]
		[Category("PlayerHP Type Test")]
		public void PlayerHPTypeTest(){
			Assert.That(gamedatacontroller.GetPlayerHP(),Is.TypeOf(typeof(int)));
		}

		[Test]
		[Category("PlayerHP Get Value Test")]
		public void PlayerHPGetValueTest(){
			Assert.That(10,Is.EqualTo(gamedatacontroller.GetPlayerHP()));
		}

		[Test]
		[Category("InitPlayerHP Type Test")]
		public void InitPlayerHPTypeTest(){
			Assert.That(gamedatacontroller.GetInitPlayerHP(),Is.TypeOf(typeof(int)));
		}
		
		[Test]
		[Category("PlayerHP Get Value Test")]
		public void InitPlayerHPGetValueTest(){
			Assert.That(10,Is.EqualTo(gamedatacontroller.GetInitPlayerHP()));
		}

		[Test]
		[Category("BaseHP Type Test")]
		public void BaseHPTypeTest(){
			Assert.That(gamedatacontroller.GetBaseHP(),Is.TypeOf(typeof(int)));
		}
		
		[Test]
		[Category("BaseHP Get Value Test")]
		public void BaseHPGetValueTest(){
			int baseHP = gamedatacontroller.GetBaseHP();
			Assert.That(15,Is.EqualTo(baseHP));
		}
		
		[Test]
		[Category("Score Type Test")]
		public void ScoreTypeTest(){
			Assert.That(gamedatacontroller.GetScore(),Is.TypeOf(typeof(int)));
		}
		
		[Test]
		[Category("Score Get Value Test")]
		public void ScoreGetValueTest(){
			int score = gamedatacontroller.GetScore();
			Assert.That(0,Is.EqualTo(score));
		}
		
		[Test]
		[Category("Money Type Test")]
		public void MoneyTypeTest(){
			Assert.That(gamedatacontroller.Getmonery(),Is.TypeOf(typeof(int)));
		}
		[Test]
		[Category("Get Money Test")]
		public void MoneyGetValueTest(){
			int money = gamedatacontroller.Getmonery();
			Assert.That(1000,Is.EqualTo(money));
		}

		private IGameDataController GetGameDataMock(){
			return Substitute.For<IGameDataController>();
		}

		private GameDataController GetGameDataControllerMock(IGameDataController Igamedata){
			var gamedatacontroller = Substitute.For<GameDataController>();
			gamedatacontroller.SetGameDataController(Igamedata);
			return gamedatacontroller;
		}

	}
}
