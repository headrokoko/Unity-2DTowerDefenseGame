using UnityEngine;
using Assets.Code.EnemyStates;
using Assets.Code.Interfaces;

namespace Assets.Code.EnemyStates{
	public class MarchState : EnemyStateManager {
		public Transform Target;
		public float Range = 5f;
		public float Speed = 0.01f;

		private EnemyStateManager Emanager;

		public MarchState(EnemyStateManager Estatemanager){
			Emanager = Estatemanager;

		}

	// Use this for initialization
	void Start () {
	
	}
	
	public void StateUpdata(){
		Debug.Log("MarchState");
	}

	// Update is called once per frame
		void Update () {
			RaycastHit hit;
			Vector3 loolup = transform.position + ((Vector3.right *5) + (Vector3.up * 5));
			
			transform.LookAt(Target,Vector3.up);
			transform.Translate(Vector3.forward * Speed);
			if(Physics.Raycast(transform.position,transform.forward,out hit,Range))
			{
				if(hit.collider.tag == "Player"){
					Debug.Log ("Player視認");
					Emanager.SwichState(new AttackState(Emanager));
				}
			}
			if(Physics.Raycast(transform.position,transform.forward + transform.up,out hit,Range))
			{
				if(hit.collider.tag == "Player"){
					Debug.Log ("Player視認2");
					Emanager.SwichState(new AttackState(Emanager));
				}
			}
		}
	}
}
