using UnityEngine;
using Assets.Code.EnemyStates;
using Assets.Code.Interfaces;

namespace Assets.Code.EnemyStates{
	public class MarchState : MonoBehaviour,EnemyState {
		public Vector3 Target;
		public float Range = 5f;
		public float Speed = 0.01f;
		private Vector3 enemypos;

		private EnemyStateManager Emanager;

		public MarchState(EnemyStateManager Estatemanager){
			Emanager = Estatemanager;

		}
	
		public void EStateUpdata(){
			RaycastHit hit;
			Debug.Log("March");
			GameObject objTarget = GameObject.FindGameObjectWithTag("Defense");
			Target = objTarget.transform.position;
			//Vector3 loolup = transform.position + ((Vector3.right *5) + (Vector3.up * 5));
			Debug.Log(Target);
			transform.LookAt(Target);
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
