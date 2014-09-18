using UnityEngine;
using System.Collections;

public class MarchState : EnemyFSMState {

	public MarchState(Transform[] wp){

		waypoints =wp;
		stateID = FSMStateID.March;

		curSpeed = 1.0f;
		curRotSpeed = 100.0f;
	}

	public override void Reason(Transform Player,Transform npc){
		
	}
	
	public override void Act(Transform player, Transform npc)
	{
		//Find another random patrol point if the current point is reached
		//ターゲット地点に到着した場合に、パトロール地点を再度策定
		if (Vector3.Distance(npc.position, destPos) <= 100.0f)
		{
			Debug.Log("Reached to the destination point\ncalculating the next point");
			FindNextPoint();
		}
		
		//ターゲットに回転
		Quaternion targetRotation = Quaternion.LookRotation(destPos - npc.position);
		npc.rotation = Quaternion.Slerp(npc.rotation, targetRotation, Time.deltaTime * curRotSpeed);
		
		//前進
		npc.Translate(Vector3.forward * Time.deltaTime * curSpeed);
	}
}
