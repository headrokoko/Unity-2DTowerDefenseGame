using UnityEngine;
using System.Collections;

namespace Limone{
	public class MarchState : EnemyFSMState {
		public float Range = 5f;
		public EnemyController enemycontroller;

		public MarchState(Transform target){

			stateID = FSMStateID.March;

			moveSpeed = 1.0f;
			RotSpeed = 100.0f;
		}

		public override void Reason(Transform Player,Transform npc){
			RaycastHit hit;
			if(Physics.Raycast(npc.transform.position,npc.transform.forward,out hit,Range))
			{
				if(hit.collider.tag == "Player"){
					Debug.Log ("SawPlayer Swich AttackState");

					Transform npcChild = npc.FindChild("Enemymodel");
					npcChild.renderer.material.color =Color.yellow;
					npc.renderer.material.color = Color.yellow;
					npc.GetComponent<EnemyController>().SetTransition(Transition.SawPlayer);
				}
			}
		}
	
		public override void Act(Transform player, Transform npc, Transform target)
		{
			RaycastHit floorHit;
			//Debug.Log ("marchstate");

			//npcの下にfloorがあるか
			if(Physics.Raycast(npc.transform.position,npc.transform.up * -1,out floorHit,2)){
				Vector3 subTarget;
				subTarget = target.position;
				subTarget.y = npc.transform.position.y;
				npc.transform.LookAt(subTarget,Vector3.up);
			}
			else{
				npc.transform.LookAt(target,Vector3.up);
			}
			//前進
			npc.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
		}
	}
}
