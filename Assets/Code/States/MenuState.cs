using UnityEngine;

namespace Limone{
	public class MenuState : IState {
	
		private GameStateManager manager;
		public MenuState(GameStateManager gamestateManager){
			manager = gamestateManager;
			Time.timeScale = 0;
		}
	
		public void StateUpdata(){
		}
	
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),manager.gameData.menuTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 5,(Screen.width/10) * 2,(Screen.height/10) * 1),"StageSelect")){
				Time.timeScale = 1;
				Debug.Log("StageSelect");
				manager.SwichState(new StageSelectState(manager));
			}

			else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 6 ,(Screen.width/10) * 2,(Screen.height/10) * 1),"Trade")){
				Time.timeScale = 1;
				Debug.Log("Trade");
			}

			else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 7,(Screen.width/10) * 2,(Screen.height/10) * 1),"AssemblyState")){
				Time.timeScale = 1;
				Debug.Log("AssemblyState");
			}
		}
	}
}