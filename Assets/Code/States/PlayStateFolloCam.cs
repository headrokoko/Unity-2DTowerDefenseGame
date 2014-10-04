using UnityEngine;
using Limone.Assets.Code.Interfaces;
using Limone;

namespace Limone{
	namespace Assets.Code.States{
		public class PlayStateFollowCam : IState {
			private GameStateManager gamemanager;
			private GameData gamedata;
			private SpwanController spwancontroller;
			private AttackStateManager Attackmanager;
			private FollowCamera Fcamera;
		
			public PlayStateFollowCam(GameStateManager gamestateManager){
				gamemanager = gamestateManager;
				Debug.Log("Follor com state");
				gamedata = GameObject.Find("GameManager").GetComponent<GameData>();
				Attackmanager = GameObject.Find("Player").GetComponent<AttackStateManager>();
				Fcamera = GameObject.Find("FollowCamera").GetComponent<FollowCamera>();
			}
		
			public void StateUpdata(){
				//Debug.Log("play state stateup");
				spwancontroller = GameObject.Find("EnemySpwanManager").GetComponent<SpwanController>();

				if(Input.GetKeyDown(KeyCode.Return)){
					Time.timeScale = 0;
					gamemanager.SwichState(new ResultState(gamemanager));
				}

				//Baseの耐久値が０
				if(gamedata.BaseHP <= 0){
					Time.timeScale = 0;
					gamemanager.SwichState(new ResultState(gamemanager));			
				}

				//既定のWave数をこなす
				if(spwancontroller.StageClear == true){
					Time.timeScale = 0;
					Debug.Log("All Wave Clear");
					gamemanager.SwichState(new ResultState(gamemanager));	
				}
				//GunShotStateに遷移
				if(Input.GetKeyDown(KeyCode.F1)){
					Debug.Log("Gun shot mode");
					Attackmanager.weaponNum = 0;
				}
				//FloorTrapStateに遷移
				else if(Input.GetKeyDown(KeyCode.F2)){
					Debug.Log("Floor trap mode");
					Attackmanager.weaponNum = 1;
					Fcamera.CameraChange(true);
				}
				//WallTrapStateに遷移
				else if(Input.GetKeyDown(KeyCode.F3)){
					Debug.Log("Wall trap mode");
					Attackmanager.weaponNum = 2;
				}
				//LoofTrapStateに遷移
				else if(Input.GetKeyDown(KeyCode.F4)){
					Debug.Log("Loof trap mode");
					Attackmanager.weaponNum = 3;
					Fcamera.CameraChange(false);
				}
			}

			public void Render(){
				if(GUI.Button(new Rect(50,450,50,50),"Gun")){
					Debug.Log("Gun shot mode");
					Attackmanager.weaponNum = 0;
					//AttackManager.AttackChange(new GunShotState(AttackManager));
				}
			
				else if(GUI.Button(new Rect(100,450,50,50),"Floor")){
					Debug.Log("Floor trap mode");
					Attackmanager.weaponNum = 1;
					Fcamera.CameraChange(true);
					//.AttackChange(new FloorTrapState(AttackManager));
				}
			
				else if(GUI.Button(new Rect(150,450,50,50),"Wall")){
					Debug.Log("Wall trap mode");
					Attackmanager.weaponNum = 2;
				}
			
				else if(GUI.Button(new Rect(200,450,50,50),"Loof")){
					Debug.Log("Loof trap mode");
					Attackmanager.weaponNum = 3;
					Fcamera.CameraChange(false);
				}
			}

		
			void CameraChange(){
				foreach(GameObject camera in gamemanager.gameData.cameras){
					if(camera.name != "FollowCamera"){
						camera.SetActive(true);
					}
					else{
						camera.SetActive(false);
					}
				}
			}
		}
	}
}