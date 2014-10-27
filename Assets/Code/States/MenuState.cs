using UnityEngine;

namespace Limone{
	public class MenuState : IState {
	
		private GameStateManager gamemanager;

		public MenuState(GameStateManager gamestateManager){
			gamemanager = gamestateManager;
			Time.timeScale = 0;
		}
	
		public void StateUpdata(){
		}
		void Init(){
		}
	
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gamemanager.gameData.menuTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 5,(Screen.width/10) * 2,(Screen.height/10) * 1),"StageSelect")){
				Time.timeScale = 0;
				Debug.Log("StageSelect");
				gamemanager.SwichState(new StageSelectState(gamemanager));
			}

			//else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 6 ,(Screen.width/10) * 2,(Screen.height/10) * 1),"Trade")){
				//Time.timeScale = 0;
				//Debug.Log("Trade");
			//}

			//else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 7,(Screen.width/10) * 2,(Screen.height/10) * 1),"AssemblyState")){
				//Time.timeScale = 0;
				//Debug.Log("AssemblyState");
			//}
		}
	}
}