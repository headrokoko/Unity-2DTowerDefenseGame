using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

public class StateManager : MonoBehaviour {
	
	private IState activeState;
	private IState activeCameraState;
	[HideInInspector]
	public GameData gameData;
	public static StateManager instance;
	
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
		activeState = new BeginState(this);
		gameData = GetComponent<GameData> ();
	}
	
	void Update () {
		if(activeState != null){
			activeState.StateUpdate();
		}
	}
	
	public void SwichState(IState newState){
		activeState = newState;
		Debug.Log(activeState);
	}
	
}