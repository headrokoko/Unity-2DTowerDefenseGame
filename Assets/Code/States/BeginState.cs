using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class BeginState : IState {
		
		private StateManager manager;
		public BeginState(StateManager stateManager){
			manager = stateManager;
			Time.timeScale = 0;
		}

		public void StateUpdate(){
			//Debug.Log("Begin State");
			if(Input.GetKeyDown(KeyCode.F1)){
				Application.LoadLevel("TDGStage1");
				Debug.Log("ステージ１");
				Time.timeScale = 1;
				manager.SwichState(new MenuState(manager));
			}
		}
		
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),manager.gameData.beginTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect(250,450,250,50),"Start")){
				Application.LoadLevel("TDGStage1");
				Time.timeScale = 1;
				Debug.Log("ステージ１");
				manager.SwichState(new MenuState(manager));
			}
		}
		
	}
}