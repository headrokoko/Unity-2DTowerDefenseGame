using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test{
	
	[TestFixture]
	[Category("StateManager Test")]
	
	public class StateManagerTest{
		
		public IStateManagerController istatemanager;
		public StateManagerController statemanager;
		public GameStateManager gamemanager;
		
		[SetUp] public void Init(){
			this.istatemanager = GetStateManagerMock();
			this.statemanager = GetStateControllerMock(istatemanager);
			gamemanager = new GameStateManager();
		}
		
		[TearDown] public void Cleanup(){
		}
		
		[Test]
		[Category("StateName ActiveState Get Test")]
		public void StateNameActiveStateGetTest(){
			Assert.That("GameBeginState",Is.EqualTo(istatemanager.SwichState(new GameBeginState(gamemanager))));
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
