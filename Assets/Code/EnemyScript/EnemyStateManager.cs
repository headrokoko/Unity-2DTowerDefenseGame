using UnityEngine;
using Assets.Code.EnemyStates;

public class EnemyStateManager : MonoBehaviour {
	
	private EnemyStateManager enemyState;
	[HideInInspector]
	public GameData gameData;

	
	void Start () {
		enemyState = new MarchState(this);
	}
	
	void Update () {
		enemyState = new MarchState(this);
		Debug.Log("Enemy State :" + enemyState);
	}
	
	public void SwichState(EnemyStateManager newState){
		enemyState = newState;
		Debug.Log("Enemy State :" + enemyState);
	}
	
}