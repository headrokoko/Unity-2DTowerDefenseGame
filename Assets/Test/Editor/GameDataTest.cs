using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test{
	
	[TestFixture]
	[Category("GameData Test")]

	public class GameDataTest{
		public IGameDataController IPlayerHP;
		public IGameDataController IBaseHP;
		public IGameDataController IScore;
		public IGameDataController IMoney;
		public GameDataController PlayerHPdata;
		public GameDataController BaseHPdata;
		public GameDataController Scoredata;
		public GameDataController Moneydata;
		
		[SetUp] public void Init(){
			this.IPlayerHP = GetGameDataMock();
			this.PlayerHPdata = GetPlayerHPMock(IPlayerHP);
			this.PlayerHPdata.gamedataController.FormatPlayerHP().Returns(10);
			this.PlayerHPdata.gamedataController.GetPlayerHPdata().Returns(10);

			this.IBaseHP = GetGameDataMock();
			this.BaseHPdata = GetBaseHPMock(IBaseHP);
			this.BaseHPdata.gamedataController.FormatBaseHP().Returns(5);
			this.BaseHPdata.gamedataController.GetBaseHPdata().Returns(5);

			this.IScore = GetGameDataMock();
			this.Scoredata = GetScoreMock(IScore);
			this.Scoredata.gamedataController.FormatScore().Returns(100);
			this.Scoredata.gamedataController.GetScoredata().Returns(100);

			this.IMoney = GetGameDataMock();
			this.Moneydata = GetMoneyMock(IMoney);
			this.Moneydata.gamedataController.FormatMoney().Returns(1000);
			this.Moneydata.gamedataController.GetMoneydata().Returns(1000);

		}

		
		[TearDown] public void Cleanup(){
		}
		
		[Test]
		[Category("PlayerHP Test")]
		public void PlayerHPTest(){
			int PlayerHP = PlayerHPdata.GetPlayerHP(10);
			Assert.That(10,Is.EqualTo(PlayerHP));
		}

		[Test]
		[Category("PlayerHP Range Test")]
		public void PlayerHPRangeTest([Range(-5,5,1)]int x){
			int PlayerHP = PlayerHPdata.GetPlayerHP(x);
			Assert.That(x,Is.EqualTo(PlayerHP));
		}

		[Test]
		[Category("PlayerHP Format Test")]
		public void PlayerFormatTest(){
			int PlayerHP = IPlayerHP.FormatPlayerHP();
			Assert.That(10,Is.EqualTo(PlayerHP));
		}

		[Test]
		[Category("Get PlayerHP Test")]
		public void GetPlayerHPTest(){
			int PlayerHP = PlayerHPdata.GetPlayerHP(IPlayerHP.GetPlayerHPdata());
			Assert.That(10,Is.EqualTo(PlayerHP));
		}
		
		[Test]
		[Category("BaseHP Test")]
		public void BaseHPTest(){
			int baseHP = BaseHPdata.GetBaseHP(5);
			Assert.That(5,Is.EqualTo(baseHP));
		}
		
		[Test]
		[Category("BaseHP Range Test")]
		public void BaseHPRangeTest([Range(-2,2,1)]int x){
			int baseHP = BaseHPdata.GetBaseHP(x);
			Assert.That(x,Is.EqualTo(baseHP));
		}
		
		[Test]
		[Category("BaseHP Format Test")]
		public void BaseHPFormatTest(){
			int baseHP = IBaseHP.FormatBaseHP();
			Assert.That(5,Is.EqualTo(baseHP));
		}
		
		[Test]
		[Category("Get BaseHP Test")]
		public void GetBaseHPTest(){
			int baseHP = BaseHPdata.GetBaseHP(IBaseHP.GetBaseHPdata());
			Assert.That(5,Is.EqualTo(baseHP));
		}
		
		[Test]
		[Category("Score Test")]
		public void ScoreTest(){
			int score = Scoredata.GetScore(100);
			Assert.That(100,Is.EqualTo(score));
		}
		
		[Test]
		[Category("Score Range Test")]
		public void ScoreRangeTest([Range(-2,2,1)]int x){
			int score = Scoredata.GetScore(x);
			Assert.That(x,Is.EqualTo(score));
		}
		
		[Test]
		[Category("Score Format Test")]
		public void ScoreFormatTest(){
			int score = IScore.FormatScore();
			Assert.That(100,Is.EqualTo(score));
		}
		
		[Test]
		[Category("Get Score Test")]
		public void GetScoreTest(){
			int score = Scoredata.GetScore(IScore.GetScoredata());
			Assert.That(100,Is.EqualTo(score));
		}
		
		[Test]
		[Category("Money Test")]
		public void MoneyTest(){
			int money = Moneydata.Getmonery(1000);
			Assert.That(1000,Is.EqualTo(money));
		}
		
		[Test]
		[Category("Money Range Test")]
		public void MoneyRangeTest([Range(-3,3,1)]int x){
			int money = Moneydata.Getmonery(x);
			Assert.That(x,Is.EqualTo(money));
		}
		
		[Test]
		[Category("Money Format Test")]
		public void MoneyFormatTest(){
			int money = IMoney.FormatMoney();
			Assert.That(1000,Is.EqualTo(money));
		}
		
		[Test]
		[Category("Get Money Test")]
		public void GetMoneyTest(){
			int money = Moneydata.Getmonery(IMoney.GetMoneydata());
			Assert.That(1000,Is.EqualTo(money));
		}

	
		

		private IGameDataController GetGameDataMock(){
			return Substitute.For<IGameDataController>();
		}

		private GameDataController GetPlayerHPMock(IGameDataController PlayerHP){
			var playerHP = Substitute.For<GameDataController>();
			playerHP.SetPlayerHPDataController(PlayerHP);
			return playerHP;
		}

		private GameDataController GetBaseHPMock(IGameDataController BaseHP){
			var baseHP = Substitute.For<GameDataController>();
			baseHP.SetBaseHPDataController(BaseHP);
			return baseHP;
		}

		private GameDataController GetScoreMock(IGameDataController Score){
			var score = Substitute.For<GameDataController>();
			score.SetScoreDataController(Score);
			return score;			
		}

		private GameDataController GetMoneyMock(IGameDataController Money){
			var money = Substitute.For<GameDataController>();
			money.SetMoneyDataController(Money);
			return money;
		}

	}
}
