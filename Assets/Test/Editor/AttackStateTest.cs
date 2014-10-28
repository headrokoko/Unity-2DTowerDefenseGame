using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test{
	
	[TestFixture]
	[Category("StateManager Test")]
	public class AttackStateTest {
		public IAttackStateController Iattackcontroller;
		public AttackStateController attackcontroller;
		
		[SetUp] public void Init(){
			this.Iattackcontroller = GetAttackStateMock();
			this.attackcontroller = GetAttackstateControllerMock(Iattackcontroller);
			Iattackcontroller.FormatClickPos().Returns("test");
			Iattackcontroller.FormatClickPosOffset().Returns("test");
			Iattackcontroller.GetClickPos().Returns("Testtest");
			Iattackcontroller.ClickPosOffset().Returns("OffsetTest");
		}
		
		[TearDown] public void Cleanup(){
		}

		[Test]
		[Category("Click Pos Format Test")]
		public void ClickPositionFormatTest(){
			Assert.That("test",Is.EqualTo(Iattackcontroller.FormatClickPos()));
		}
		[Test]
		[Category("Click Pos Offset Format Test")]
		public void ClickPositionOffsetTest(){
			Assert.That("test",Is.EqualTo(Iattackcontroller.FormatClickPosOffset()));
		}

		[Test]
		[Category("Click Pos Get Test")]
		public void ClickPosGetTest(){
			Assert.That("Testtest",Is.EqualTo(Iattackcontroller.GetClickPos()));
		}
		[Test]
		[Category("Click Pos Offset Get Test")]
		public void ClickPosOffsetGetTest(){
			Assert.That("OffsetTest",Is.EqualTo(Iattackcontroller.ClickPosOffset()));
		}

		public IAttackStateController GetAttackStateMock(){
			return Substitute.For<IAttackStateController>();
		}
		public AttackStateController GetAttackstateControllerMock(IAttackStateController Iattackstate){
			var attackstatemanager = Substitute.For<AttackStateController>();
			attackstatemanager.SetAttackStateManagerController(Iattackstate);
			return attackstatemanager;
		}

	}
}
