using UnityEngine;

namespace Limone{
	public class StageSelectState : IState {
	
		private GameStateManager gamemanager;
		private GameObject player;
		private GameData gamedata;
		private AudioSource StartSe;
		private bool initbool = true;

		public StageSelectState (GameStateManager gamestateManager){
			gamemanager = gamestateManager;
			Time.timeScale = 0;
		}
		
		void Init(){
			gamedata = GameObject.Find("GameManager").GetComponent<GameData>();
			StartSe = GameObject.Find("FollowCamera").GetComponent<AudioSource>();
			player = GameObject.Find("Player");
		}
	
		public void StateUpdata(){
			if(initbool){
				initbool = false;
				Init();
			}
		}

	
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gamemanager.gameData.stageselectTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 4,(Screen.width/10) * 2,(Screen.height/10) * 1),"Stage1")){
				Application.LoadLevel("TDGStage1");
				Debug.Log("ステージ１");
				int startmoney = 1000;
				GoNextState(startmoney);
			}
		
			else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 5,(Screen.width/10) * 2,(Screen.height/10) * 1),"Stage2")){
				Application.LoadLevel("TDGStage2");
				Debug.Log("ステージ2");
				int startmoney = 1000;
				GoNextState(startmoney);
			}
		
			else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 6,(Screen.width/10) * 2,(Screen.height/10) * 1),"Stage3")){
				Application.LoadLevel("TDGStage3");
				Debug.Log("ステージ3");
				int startmoney = 1000;
				GoNextState(startmoney);
			}
		
			else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 7,(Screen.width/10) * 2,(Screen.height/10) * 1),"Stage4")){
				Application.LoadLevel("TDGStage4");
				Debug.Log("ステージ4");
				int startmoney = 1000;
				GoNextState(startmoney);
			}
		
			else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 8,(Screen.width/10) * 2,(Screen.height/10) * 1),"test")){
				Application.LoadLevel("testscene");
				Debug.Log("テストステージ");
				int startmoney = 1000;
				GoNextState(startmoney);
			}
		}

		public void GoNextState(int money){
			Time.timeScale = 1;
			gamedata.Money = money;
			StartSe.PlayOneShot(StartSe.clip);
			player.transform.position = new Vector3(0.0f,2.0f,0.0f);
			gamemanager.SwichState(new PlayStateFollowCam(gamemanager));
			initbool = true;
		}
	}
}