using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States{
	public class PlayState : IState {
		private GameStateManager manager;
		private DefenseObjData basedata;

		public PlayState(GameStateManager stateManager){
			manager = stateManager;
			basedata = GameObject.Find("Base").GetComponent<DefenseObjData>();
		}
		
		public void StateUpdata(){
			//Debug.Log("play state stateup");
			if(Input.GetKeyDown(KeyCode.Return)){
				manager.SwichState(new ResultState(manager));
			}
			//Baseの耐久値が０
			if(basedata.DefObjHP <= 0){
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