using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test{
	
	[TestFixture]
	[Category("GuiBaseHP Test")]
	
	public class GuiBaseHPTest{
		
		public IGUIBaseHPController ibaseHP;
		public GuiBaseHPController baseHP;
		
		[SetUp] public void Init(){
			this.ibaseHP = GetBaseHPMock();
			this.baseHP = GetControllerMock(ibaseHP);
			this.baseHP.baseHPController.FormatBaseHP().Returns("BaseHP :100");
			this.baseHP.baseHPController.GetGameData().Returns(100);
		}
		
		[TearDown] public void Cleanup(){
		}
		
		[Test]
		[Category("BaseHP Test")]
		public void BaseHPTest(){
			string text = baseHP.GetBaseHPText(100);
			Assert.That("BaseHP :100",Is.EqualTo(text));
		}
		
		[Test]
		[Category("BaseHP Range Test")]
		public void BaseHPTest([Range(-4,4,1)]int x){
			string text = baseHP.GetBaseHPText(x);
			Assert.That("BaseHP :" + x.ToString(),Is.EqualTo(text));
		}
		
		[Test]
		[Category("BaseHP Format Test")]
		public void BaseHPFormatTest(){
			string text = ibaseHP.FormatBaseHP();
			Assert.That("BaseHP :100",Is.EqualTo(text));
		}
		
		[Test]
		[Category("BaseHP Format Test")]
		public void GetGameDataTest(){
			string text = baseHP.GetBaseHPText(ibaseHP.GetGameData());
			Assert.That("BaseHP :100",Is.EqualTo(text));
		}
		
		private IGUIBaseHPController GetBaseHPMock(){
			return Substitute.For<IGUIBaseHPController>();
		}
		
		private GuiBaseHPController GetControllerMock(IGUIBaseHPController ibaseHP){
			var baseHP = Substitute.For<GuiBaseHPController>();
			baseHP.SetGuiBaseHPController(ibaseHP);
			//status.calcTime().Return(0.0f);
			return baseHP;
		}
	}
}
