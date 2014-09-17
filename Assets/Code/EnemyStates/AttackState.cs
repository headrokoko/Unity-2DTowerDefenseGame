using UnityEngine;
using Assets.Code.EnemyStates;
using Assets.Code.Interfaces;
using System.Collections;

namespace Assets.Code.EnemyStates{
public class AttackState :  MonoBehaviour,EnemyState{

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
		
		public void EStateUpdata(){
			Debug.Log("Attack");

			if(Input.GetKeyDown(KeyCode.Q)){
				Connection();
			}
	
		}

		//遷移処理
		public void Connection(){
			Emanager.SwichState(new MarchState(Emanager));
		}
}
}
