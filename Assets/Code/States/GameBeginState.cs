using UnityEngine;

namespace Limone{
	public class GameBeginState : IState {
	
		private GameStateManager gamemanager;
		private GameDataController Gamecontroller;
		private AttackStateManager attackmanager;
		private GameData gamedata;

		public GameBeginState(GameStateManager gamestateManager){
			gamemanager = gamestateManager;
			Gamecontroller = new GameDataController();
			Time.timeScale = 0;
		}

		public void StateUpdata(){
			//Debug.Log("Begin State");
			if(Input.GetKeyDown(KeyCode.F1)){
				Application.LoadLevel("TDGStage1");
				Debug.Log("ステージ１");
				Time.timeScale = 1;
				gamemanager.SwichState(new MenuState(gamemanager));
			}
		}

		void Init(){
		}
	
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gamemanager.gameData.startTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect((Screen.width/10)*5,(Screen.height/10)*8 ,(Screen.width/10)*2,(Screen.height/10)*1),"Start")){
				Application.LoadLevel("TDGStage1");
				Time.timeScale = 1;
				Debug.Log("ステージ１");
				gamemanager.SwichState(new MenuState(gamemanager));
			}
		}
	}
}