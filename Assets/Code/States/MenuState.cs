using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class MenuState : IState {
		
		private StateManager manager;
		public MenuState(StateManager stateManager){
			manager = stateManager;
			Time.timeScale = 0;
		}
		
		public void StateUpdata(){
		}
		
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),manager.gameData.menuTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect(50,200,250,50),"StageSelect")){
				Time.timeScale = 1;
				Debug.Log("StageSelect");
				manager.SwichState(new StageSelectState(manager));
			}

			else if(GUI.Button(new Rect(50,250,250,50),"Trade")){
				Time.timeScale = 1;
				Debug.Log("Trade");
			}

			else if(GUI.Button(new Rect(50,300,250,50),"AssemblyState")){
				Time.timeScale = 1;
				Debug.Log("AssemblyState");
			}

		}
		
	}
}