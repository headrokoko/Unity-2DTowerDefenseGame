using UnityEngine;
using System.Collections;

public class MarchState : EnemyFSMState {
	public float Range = 5f;

	public MarchState(Transform target){

		stateID = FSMStateID.March;

		curSpeed = 1.0f;
		curRotSpeed = 100.0f;
	}

	public override void Reason(Transform Player,Transform npc){
		RaycastHit hit;
		if(Physics.Raycast(npc.transform.position,npc.transform.forward,out hit,Range))
		{
			if(hit.collider.tag == "Player"){
				Debug.Log ("Player視認");
				npc.GetComponent<EnemyController>().SetTransition(Transition.SawPlayer);
			}
		}
		
	}
	
	public override void Act(Transform player, Transform npc, Transform target)
	{
		Debug.Log ("marchstate");

		//Find another random patrol point if the current point is reached
		//ターゲット地点に到着した場合に、パトロール地点を再度策定
		//if (Vector3.Distance(npc.position, destPos) <= 100.0f)
		//{
			//Debug.Log("Reached to the destination point\ncalculating the next point");
			//FindNextPoint();
		//}
		
		//ターゲットに回転
		npc.transform.LookAt(target,Vector3.up);
		//Quaternion targetRotation = Quaternion.LookRotation(destPos - npc.position);
		//npc.rotation = Quaternion.Slerp(npc.rotation, targetRotation, Time.deltaTime * curRotSpeed);
		
		//前進
		npc.Translate(Vector3.forward * Time.deltaTime * curSpeed);
	}
}
