using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test{
	
	[TestFixture]
	[Category("StateManager Test")]
	
	public class StateManagerTest{
		
		public IStateManagerController istatemanager;
		public StateManagerController statemanager;
		
		[SetUp] public void Init(){
			this.istatemanager = GetStateManagerMock();
			this.statemanager = GetStateControllerMock(istatemanager);
			this.statemanager.Statecontroller.FormatStateManager().Returns("GameBeginState");
			this.statemanager.Statecontroller.GetStateName().Returns("GameBeginState");
		}
		
		[TearDown] public void Cleanup(){
		}
		
		[Test]
		[Category("State Test")]
			public void StateTest(){
				string state = statemanager.GetStateName("GameBeginState");
				Assert.That("GameBeginState",Is.EqualTo(state));
			}
		
		[Test]
		[Category("State Format Test")]
			public void StateFormatTest(){
				string state = istatemanager.FormatStateManager();
				Assert.That("GameBeginState",Is.EqualTo(state));
			}
		
		[Test]
		[Category("Get State Name Test")]
			public void GetStateNameTest(){
				string state = statemanager.GetStateName(istatemanager.GetStateName());
				Assert.That("GameBeginState",Is.EqualTo(state));
		}

		[Test]
		[Category("State Pattern Test")]
		public void StatePatternTest([Values(
			"GameBeginState",
			"MenuState",
            "TradeState",
            "StageSelectState",
            "PlayStateFollowCam",
            "ResultState")]string statename){
				Assert.That(statename,Is.EqualTo(statename));
		}
		
		private IStateManagerController GetStateManagerMock(){
			return Substitute.For<IStateManagerController>();
		}
		
		private StateManagerController GetStateControllerMock(IStateManagerController istatemanager){
			var statemanager = Substitute.For<StateManagerController>();
			statemanager.SetStateManagerController(istatemanager);
			//status.calcTime().Return(0.0f);
			return statemanager;
		}
	}
}
