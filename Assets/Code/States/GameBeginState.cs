using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class GameBeginState : IState {
		
		private GameStateManager gamemanager;
		public GameBeginState(GameStateManager gamestateManager){
			gamemanager = gamestateManager;
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
		
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gamemanager.gameData.beginTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect(250,450,250,50),"Start")){
				Application.LoadLevel("TDGStage1");
				Time.timeScale = 1;
				Debug.Log("ステージ１");
				gamemanager.SwichState(new MenuState(gamemanager));
			}
		}
		
	}
}