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
			this.statemanager.Statecontroller.FormatState().Returns("GameBeginState");
			//this.statemanager.Statecontroller.SwichState(new GameBeginState(statemanager.statemanager));
			//this.statemanager.Statecontroller.GetActiveStateName().Returns("GameBeginState");
		}
		
		[TearDown] public void Cleanup(){
		}

		[Test]
		[Category("StateName Get Test")]
		public void StateNameFormatTest(){
			string statename = istatemanager.FormatState();
			Assert.That("GameBeginState",Is.EqualTo(statename));
		}
		[Test]
		[Category("StateName Active State Get Test")]
		public void StateNameActiveStateGetTest(){
			string actstate = statemanager.statemanager.SwichState(new GameBeginState(gamemanager));
			Assert.That("Limone.GameBeginState",Is.EqualTo(actstate));
		}
		[Test]
		[Category("StateName GameBeginState Get Test")]
		public void StateNameGameBeginStateGetTest(){
			string actstate = statemanager.statemanager.SwichState(new GameBeginState(this.gamemanager));
			Assert.That("Limone.GameBeginState",Is.EqualTo(actstate));
		}
		[Test]
		[Category("StateName MenuState Get Test")]
		public void StateNameMenuStateGetTest(){
			string actstate = statemanager.statemanager.SwichState(new MenuState(this.gamemanager));
			Assert.That("Limone.MenuState",Is.EqualTo(actstate));
		}
		[Test]
		[Category("StateName StageSelectState Get Test")]
		public void StateNameSelectStateGetTest(){
			string actstatename = statemanager.statemanager.SwichState(new StageSelectState(gamemanager));
			Assert.That("Limone.StageSelectState",Is.EqualTo(actstatename));
		}
		[Test]
		[Category("StateName PlayState Get Test")]
		public void StateNamePlayStateGetTest(){
			string actstate = statemanager.statemanager.SwichState(new PlayStateFollowCam(gamemanager));
			Assert.That("Limone.PlayStateFollowCam",Is.EqualTo(actstate));
		}
		[Test]
		[Category("StateName ResultState Get Test")]
		public void StateNameResultStateGetTest(){
			string actstate = statemanager.statemanager.SwichState(new ResultState(gamemanager));
			Assert.That("Limone.ResultState",Is.EqualTo(actstate));
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
