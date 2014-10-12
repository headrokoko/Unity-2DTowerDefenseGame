using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test{
	
	[TestFixture]
	[Category("GuiMoney Test")]
	
	public class GuiMoneyTest {
		
		public IGUIMoneyController imoney;
		public GuiMoneyController money;
		
		
		[SetUp] public void Init(){
			this.imoney = GetMoneyMock();
			this.money = GetMoneyControllerMock(imoney);
			this.money.moneyController.FormatMoney().Returns("Money :1000");
			this.money.moneyController.GetGameData().Returns(1000);
		}
		
		
		[TearDown] public void Cleanup(){
		}
		
		[Test]
		[Category("Money Test")]
		public void MoneyTest(){
			string text = money.GetMoneyText(1000);
			Assert.That("Money :1000",Is.EqualTo(text));
		}
		
		[Test]
		[Category("money Range Test")]
		public void MoneyTest([Range(-4,4,1)]int x){
			string text = money.GetMoneyText(x);
			Assert.That("Money :" + x.ToString(),Is.EqualTo(text));
		}
		
		[Test]
		[Category("money Format Test")]
		public void MoneyFormatTest(){
			string text = imoney.FormatMoney();
			Assert.That("Money :1000",Is.EqualTo(text));
		}
		
		[Test]
		[Category("Money Format Test")]
		public void GetGameDataTest(){
			string text = money.GetMoneyText(imoney.GetGameData());
			Assert.That("Money :1000",Is.EqualTo(text));
		}
		
		private IGUIMoneyController GetMoneyMock(){
			return Substitute.For<IGUIMoneyController>();
		}
		
		private GuiMoneyController GetMoneyControllerMock(IGUIMoneyController iplayerhp){
			var money = Substitute.For<GuiMoneyController>();
			money.SetGuiMoneyController(iplayerhp);
			return money;
		}
	}
}
