using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class PlayState : IState {
		private StateManager manager;
		
		public PlayState(StateManager stateManager){
			manager = stateManager;
		}
		
		public void StateUpdate(){
			//Debug.Log("play state stateup");
			if(Input.GetKeyDown(KeyCode.Return)){
				manager.SwichState(new ResultState(manager));
			}
		}
		
		public void Render(){
		}

	}
}