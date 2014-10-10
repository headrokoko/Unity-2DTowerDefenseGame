using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test{

	[TestFixture]
	[Category("GuiPlayerHP Test")]

	public class GuiPlayerHPTest {
		
		public IGUIPlayerHPController iplayerHP;
		public GuiPlayerHPController playerHP;

		
		[SetUp] public void Init(){
			this.iplayerHP = GetPlayerHPMock();
			this.playerHP = GetPlayerHPControllerMock(iplayerHP);
			this.playerHP.PlayerHPController.FormatPlayerHP().Returns("PlayerHP :10");
			this.playerHP.PlayerHPController.GetGameData().Returns(10);
		}

		
		[TearDown] public void Cleanup(){
		}
		
		[Test]
		[Category("PlayerHP Test")]
		public void PlayerHPTest(){
			string text = playerHP.GetPlayerHPText(10);
			Assert.That("PlayerHP :10",Is.EqualTo(text));
		}
		
		[Test]
		[Category("playerHP Range Test")]
		public void PlayerHPTest([Range(-4,4,1)]int x){
			string text = playerHP.GetPlayerHPText(x);
			Assert.That("PlayerHP :" + x.ToString(),Is.EqualTo(text));
		}
		
		[Test]
		[Category("playerHP Format Test")]
		public void PlayerHPFormatTest(){
			string text = iplayerHP.FormatPlayerHP();
			Assert.That("PlayerHP :10",Is.EqualTo(text));
		}
		
		[Test]
		[Category("PlayerHP Format Test")]
		public void GetGameDataTest(){
			string text = playerHP.GetPlayerHPText(iplayerHP.GetGameData());
			Assert.That("PlayerHP :100",Is.EqualTo(text));
		}

		private IGUIPlayerHPController GetPlayerHPMock(){
			return Substitute.For<IGUIPlayerHPController>();
		}
		
		private GuiPlayerHPController GetPlayerHPControllerMock(IGUIPlayerHPController iplayerhp){
			var playerHP = Substitute.For<GuiPlayerHPController>();
			playerHP.SetGuiPlayerHPController(iplayerhp);
			return playerHP;
		}
	}
}
