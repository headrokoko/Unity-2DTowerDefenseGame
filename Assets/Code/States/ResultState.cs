using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class ResultState : IState {
		private GameStateManager gamemanager;
		private GameData gamedata;
		
		public ResultState(GameStateManager stateManager){
			gamemanager = stateManager;
			gamedata = GameObject.Find("GameManager").GetComponent<GameData>();
		}
		
		public void StateUpdata(){
			//Debug.Log("EndState");
			if(Input.GetKeyDown(KeyCode.Return)){
				Application.LoadLevel("testScene");
				gamedata.playerHP = 10;
				gamedata.BaseHP = 10;
				gamedata.score = 0;
				gamemanager.SwichState(new MenuState(gamemanager));
			}
			
		}
		
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gamemanager.gameData.resultTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect(200,200,300,50),"Start Menu")){
				Application.LoadLevel("testScene");
				gamedata.playerHP = 10;
				gamedata.BaseHP = 10;
				gamedata.score = 0;
				gamemanager.SwichState(new MenuState(gamemanager));
			}
		}
	}
}
