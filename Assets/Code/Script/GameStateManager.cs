using UnityEngine;
using Limone;

namespace Limone{
	public class GameStateManager : MonoBehaviour {
	
		private IState activeState;
		private IState activeCameraState;
		[HideInInspector]
		public GameData gameData;
		public static GameStateManager instance;

		public bool SEbool = false;
	
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
			activeState = new GameBeginState(this);
			Debug.Log("First scene State " + activeState);
			gameData = GetComponent<GameData> ();
		}
	
		void Update () {
			if(activeState != null){
				GameObject.Find("Player").GetComponent<AudioSource>().enabled = SEbool;
				activeState.StateUpdata();
			}
		}
	
		public void SwichState(IState newState){
			activeState = newState;
			Debug.Log(activeState);
		}
	}
}