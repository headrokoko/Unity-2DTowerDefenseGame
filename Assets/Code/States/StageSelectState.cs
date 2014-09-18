using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class StageSelectState : IState {
		
		private GameStateManager gamemanager;
		public StageSelectState (GameStateManager gamestateManager){
			gamemanager = gamestateManager;
			Time.timeScale = 0;
		}
		
		public void StateUpdata(){
		}
		
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gamemanager.gameData.stageselectTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect(50,200,250,50),"Stage1")){
				Application.LoadLevel("TDGStage1");
				Time.timeScale = 1;
				Debug.Log("ステージ１");
				gamemanager.SwichState(new PlayState(gamemanager));
			}
			
			else if(GUI.Button(new Rect(50,250,250,50),"Stage2")){
				Application.LoadLevel("TDGStage2");
				Time.timeScale = 1;
				Debug.Log("ステージ2");
				gamemanager.SwichState(new PlayState(gamemanager));
			}
			
			else if(GUI.Button(new Rect(50,300,250,50),"Stage3")){
				Application.LoadLevel("TDGStage3");
				Time.timeScale = 1;
				Debug.Log("ステージ3");
				gamemanager.SwichState(new PlayState(gamemanager));
			}
			
			else if(GUI.Button(new Rect(50,350,250,50),"Stage4")){
				Application.LoadLevel("TDGStage1");
				Time.timeScale = 1;
				Debug.Log("ステージ4");
				gamemanager.SwichState(new PlayState(gamemanager));
			}
			
			else if(GUI.Button(new Rect(50,400,250,50),"test")){
				Application.LoadLevel("testscene");
				Time.timeScale = 1;
				Debug.Log("ステージ5");
				gamemanager.SwichState(new PlayState(gamemanager));
			}
		}
		
	}
}