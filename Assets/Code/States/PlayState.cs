using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class PlayState : IState {
		private GameStateManager manager;

		public PlayState(GameStateManager stateManager){
			manager = stateManager;
		}
		
		public void StateUpdata(){
			//Debug.Log("play state stateup");
			if(Input.GetKeyDown(KeyCode.Return)){
				manager.SwichState(new ResultState(manager));
			}
			if(Input.GetKeyDown(KeyCode.M)){
				CameraChange();
				manager.SwichState(new PlayStateFollowCam(manager));

			}
		}
		
		public void Render(){

			if(GUI.Button(new Rect(100,500,100,50),"Camera")){
				CameraChange();
				Debug.Log("camera Follow");
				manager.SwichState(new PlayStateFollowCam(manager));
			}
		}

		void CameraChange(){
			foreach(GameObject camera in manager.gameData.cameras){
				if(camera.name != "ZoomOutCamera"){
					camera.SetActive(true);
				}
				else{
					camera.SetActive(false);
				}
			}

		}

	}
}