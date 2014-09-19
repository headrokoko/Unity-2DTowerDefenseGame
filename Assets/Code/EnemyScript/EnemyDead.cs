using UnityEngine;
using System.Collections;

public class EnemyDead : EnemyFSMState {

	public EnemyDead(){
		stateID = FSMStateID.Dead;
	}
	
	public override void Reason(Transform player, Transform npc)
	{
		
	}
	
	public override void Act(Transform player, Transform npc, Transform target)
	{
		
	}
}
