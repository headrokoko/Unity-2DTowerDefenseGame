using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

public class GameStateManager : MonoBehaviour {
	
	private IState activeState;
	private IState activeCameraState;
	[HideInInspector]
	public GameData gameData;
	public static GameStateManager instance;
	
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
		gameData = GetComponent<GameData> ();
	}
	
	void Update () {
		if(activeState != null){
			activeState.StateUpdata();
		}
	}
	
	public void SwichState(IState newState){
		activeState = newState;
		Debug.Log(activeState);
	}
	
}