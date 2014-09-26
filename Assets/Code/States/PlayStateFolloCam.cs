using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class PlayStateFollowCam : IState {
		private GameStateManager gamemanager;
		private DefenseObjData basedata;
		private SpwanController spwancontroller;
		
		public PlayStateFollowCam(GameStateManager gamestateManager){
			gamemanager = gamestateManager;
		}
		
		public void StateUpdata(){
			//Debug.Log("play state stateup");
			basedata = GameObject.Find("Base").GetComponent<DefenseObjData>();
			spwancontroller = GameObject.Find("EnemySpwanManager").GetComponent<SpwanController>();

			if(Input.GetKeyDown(KeyCode.Return)){
				Time.timeScale = 0;
				gamemanager.SwichState(new ResultState(gamemanager));
			}

			//Baseの耐久値が０
			if(basedata.DefObjHP <= 0){
				Time.timeScale = 0;
				gamemanager.SwichState(new ResultState(gamemanager));			
			}

			//既定のWave数をこなす
			if(spwancontroller.StageClear == true){
				Time.timeScale = 0;
				Debug.Log("All Wave Clear");
				gamemanager.SwichState(new ResultState(gamemanager));	
			}
			
		}

		public void Render(){
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