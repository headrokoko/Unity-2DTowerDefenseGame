using UnityEngine;
using System.Collections;
using Limone;

namespace Limone{
	public class GameStateManager : MonoBehaviour,IStateManagerController {
	
		public IState activeState;
		private IState activeCameraState;
		public StateManagerController statecontroller;
		[HideInInspector]
		public GameData gameData;
		public static GameStateManager instance;

		public bool SEbool = false;
		
		public void OnEnable(){
			statecontroller.SetStateManagerController(this);
		}

		void Awake(){
			if(instance == null){
				instance = this;
				DontDestroyOnLoad(gameObject);
			}
			else{
				DestroyImmediate(gameObject);	
			}
		}
	
		void OnGUI(){
			//if(activeState == null){
			activeState.Render();
			//}		
		}
	
		void Start () {
			StateManagerInit();
		}
	
		void Update () {
			if(activeState != null){
				GameObject.Find("Player").GetComponent<AudioSource>().enabled = SEbool;
				activeState.StateUpdata();
			}
		}
	
		public string SwichState(IState newState){
			activeState = newState;
			Debug.Log(activeState);
			return activeState.ToString();
		}


		public void StateManagerInit(){
			activeState = new GameBeginState(this);
			Debug.Log("First scene State " + activeState);
			gameData = GetComponent<GameData> ();	
		}
	}
}