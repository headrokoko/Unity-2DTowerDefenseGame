using UnityEngine;

namespace Limone{
	public class ResultState : IState {

		private GameStateManager gamemanager;
		private GameData gamedata;
		private bool inibool = true;
		public AttackStateManager attackmanager;
	
		public ResultState(GameStateManager gamestateManager){
			gamemanager = gamestateManager;
			attackmanager = new AttackStateManager();
		}
		
		void Init(){
			gamedata = GameObject.Find("GameManager").GetComponent<GameData>();
			gamemanager.SEbool = false;
		}
	
		public void StateUpdata(){
			if(inibool){
				inibool = false;
				Init();
			}
			//Debug.Log("EndState");
			if(Input.GetKeyDown(KeyCode.Return)){
				GoNextState();
			}
		}
	
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gamemanager.gameData.resultTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect((Screen.width/2),(Screen.height/2) + 100,300,50),"Back to Menu")){
				Application.LoadLevel("testScene");
				GoNextState();
			}
		}

		public void GoNextState(){
			Application.LoadLevel("testScene");
			gamedata.playerHP = 10;
			gamedata.BaseHP = 10;
			gamedata.score = 0;
			gamemanager.SwichState(new MenuState(gamemanager));
		}
	}
}
