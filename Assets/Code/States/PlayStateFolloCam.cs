﻿using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class PlayStateFollowCam : IState {
		private StateManager manager;
		
		public PlayStateFollowCam(StateManager stateManager){
			manager = stateManager;
		}
		
		public void StateUpdate(){
			//Debug.Log("play state stateup");
			if(Input.GetKeyDown(KeyCode.Return)){
				manager.SwichState(new ResultState(manager));
			}
			if(Input.GetKeyDown(KeyCode.M)){
				CameraChange();
				manager.SwichState(new PlayState(manager));
				
			}
			
		}

		public void Render(){
			if(GUI.Button(new Rect(100,500,100,50),"Camera")){
				CameraChange();
				Debug.Log("camera ZoomOut");
				manager.SwichState(new PlayState(manager));
			}

			if(GUI.Button(new Rect(200,500,50,50),"I1")){
				Debug.Log("Item1");
			}
		}
		
		void CameraChange(){
			foreach(GameObject camera in manager.gameData.cameras){
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