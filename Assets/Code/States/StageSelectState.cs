using UnityEngine;
using Limone;

namespace Limone{
	public class StageSelectState : IState {
	
		private GameStateManager gamemanager;
		private GameObject player;
		private GameData gamedata;
		private AudioSource StartSe;
		public StageSelectState (GameStateManager gamestateManager){
			gamemanager = gamestateManager;
			gamedata = GameObject.Find("GameManager").GetComponent<GameData>();
			StartSe = GameObject.Find("FollowCamera").GetComponent<AudioSource>();
			player = GameObject.Find("Player");
			Time.timeScale = 0;
		}
	
		public void StateUpdata(){
		}
	
		public void Render(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gamemanager.gameData.stageselectTexture,ScaleMode.StretchToFill);
			if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 4,(Screen.width/10) * 2,(Screen.height/10) * 1),"Stage1")){
				Application.LoadLevel("TDGStage1");
				gamedata.Money = 1000;
				Time.timeScale = 1;
				StartSe.PlayOneShot(StartSe.clip);
				Debug.Log("ステージ１");
				gamemanager.SwichState(new PlayStateFollowCam(gamemanager));
			}
		
			else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 5,(Screen.width/10) * 2,(Screen.height/10) * 1),"Stage2")){
				Application.LoadLevel("TDGStage2");
				gamedata.Money = 1000;
				Time.timeScale = 1;
				StartSe.PlayOneShot(StartSe.clip);
				Debug.Log("ステージ2");
				gamemanager.SwichState(new PlayStateFollowCam(gamemanager));
			}
		
			else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 6,(Screen.width/10) * 2,(Screen.height/10) * 1),"Stage3")){
				Application.LoadLevel("TDGStage3");
				gamedata.Money = 1000;
				Time.timeScale = 1;
				StartSe.PlayOneShot(StartSe.clip);
				Debug.Log("ステージ3");
				gamemanager.SwichState(new PlayStateFollowCam(gamemanager));
			}
		
			else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 7,(Screen.width/10) * 2,(Screen.height/10) * 1),"Stage4")){
				Application.LoadLevel("TDGStage1");
				gamedata.Money = 1000;
				Time.timeScale = 1;
				StartSe.PlayOneShot(StartSe.clip);
				Debug.Log("ステージ4");
				gamemanager.SwichState(new PlayStateFollowCam(gamemanager));
			}
		
			else if(GUI.Button(new Rect((Screen.width/10) * 1,(Screen.height/10) * 8,(Screen.width/10) * 2,(Screen.height/10) * 1),"test")){
				Application.LoadLevel("testscene");
				gamedata.Money = 1000;
				Time.timeScale = 1;
				StartSe.PlayOneShot(StartSe.clip);
				Debug.Log("test Stage");
				player.transform.position = new Vector3(0.0f,2.0f,0.0f);
				gamemanager.SwichState(new PlayStateFollowCam(gamemanager));
			}
		}
	}
}