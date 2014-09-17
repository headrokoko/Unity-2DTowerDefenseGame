using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.EnemyStates;
using System.Collections;
using System.Collections.Generic;

public class EnemyStateManager : MonoBehaviour {
	
	private EnemyState enemyState;
	public Transform Target;
	[HideInInspector]
	public GameData gameData;

	
	void Start () {
		enemyState = new MarchState(this);
	}
	
	void Update () {
		if(enemyState != null){
			enemyState.EStateUpdata();
		}
		transform.LookAt(Target,Vector3.up);
		//Debug.Log("test");
	}

	
	public void SwichState(EnemyState newState){
		enemyState = newState;
		Debug.Log("Enemy State :" + enemyState);
	}
	
}