using UnityEngine;
using Assets.Code.EnemyStates;
using System.Collections;

public class AttackState : EnemyStateManager {

	public Transform Player;
	public float Range = 5f;
	public float Speed = 0.01f;
	private EnemyStateManager Emanager;

	public AttackState(EnemyStateManager Estatemanager){
		Emanager = Estatemanager;
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 enemy = transform.position;
		Vector3 playr = Player.transform.position;
		float dis = Vector3.Distance(enemy,playr);
		if(dis > Range){
			Debug.Log("Player Lost");
			Emanager.SwichState(new MarchState(Emanager));
		}
	
	}
}
