using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class PlayState : IState {
		private GameStateManager manager;
		private GameData gamedata;


		public PlayState(GameStateManager stateManager){
			manager = stateManager;
			gamedata = GameObject.Find("GameManager").GetComponent<GameData>();
		}
		
		public void StateUpdata(){
			//Debug.Log("play state stateup");
			if(Input.GetKeyDown(KeyCode.Return)){
				manager.SwichState(new ResultState(manager));
			}
			//Baseの耐久値が０
			if(gamedata.BaseHP <= 0){
				manager.SwichState(new ResultState(manager));			
			}
		}
		
		public void Render(){

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