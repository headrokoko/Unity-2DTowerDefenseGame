using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class ResultState : IState {
		private StateManager manager;
		
		public ResultState(StateManager stateManager){
			manager = stateManager;
		}
		
		public void StateUpdata(){
			//Debug.Log("EndState");
			if(Input.GetKeyDown(KeyCode.Return)){
				Application.LoadLevel("testScene");
				manager.SwichState(new MenuState(manager));
			}
			
		}
		
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),manager.gameData.resultTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect(200,200,300,50),"Start Menu")){
				Application.LoadLevel("testScene");
				manager.SwichState(new MenuState(manager));
			}
		}
	}
}
