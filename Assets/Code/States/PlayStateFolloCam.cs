using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class PlayStateFollowCam : IState {
		private GameStateManager gamemanager;
		
		public PlayStateFollowCam(GameStateManager gamestateManager){
			gamemanager = gamestateManager;
		}
		
		public void StateUpdata(){
			//Debug.Log("play state stateup");
			if(Input.GetKeyDown(KeyCode.Return)){
				gamemanager.SwichState(new ResultState(gamemanager));
			}
			if(Input.GetKeyDown(KeyCode.M)){
				CameraChange();
				gamemanager.SwichState(new PlayState(gamemanager));
				
			}
			
		}

		public void Render(){
			if(GUI.Button(new Rect(100,500,100,50),"Camera")){
				CameraChange();
				Debug.Log("camera ZoomOut");
				gamemanager.SwichState(new PlayState(gamemanager));
			}

			if(GUI.Button(new Rect(200,500,50,50),"I1")){
				Debug.Log("Item1");
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