using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class PlayStateFollowCam : IState {
		private GameStateManager gamemanager;
		private DefenseObjData basedata;
		
		public PlayStateFollowCam(GameStateManager gamestateManager){
			gamemanager = gamestateManager;
		}
		
		public void StateUpdata(){
			//Debug.Log("play state stateup");
			if(Input.GetKeyDown(KeyCode.Return)){
				gamemanager.SwichState(new ResultState(gamemanager));
			}
			basedata = GameObject.Find("Base").GetComponent<DefenseObjData>();
			//Baseの耐久値が０
			if(basedata.DefObjHP <= 0){
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