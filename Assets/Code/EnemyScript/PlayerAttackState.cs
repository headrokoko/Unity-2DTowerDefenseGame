using UnityEngine;
using System.Collections;

public class PlayerAttackState : EnemyFSMState {

	public PlayerAttackState(Transform player){

		stateID = FSMStateID.Attacking;
		curSpeed = 1.0f;
		curRotSpeed = 100.0f;
	}
	
	
	public override void Reason(Transform player, Transform npc)
	{
		//プレーヤーとの距離を確認
		float dist = Vector3.Distance(npc.position, player.position);
		//一定の距離内にPlayerがいなくなったらMarchstateに戻る
		if (dist >= 5.0f)
		{
			Debug.Log("PlayerLost Swich MarchState");
			npc.GetComponent<EnemyController>().SetTransition(Transition.LostPlayer);
		}  
	}
	
	public override void Act(Transform player, Transform npc, Transform target)
	{
		//ターゲットをプレイヤーに変更しそちらを向く
		npc.transform.LookAt(player.position,Vector3.up);
		npc.Translate(Vector3.forward * Time.deltaTime * curSpeed * 2);
		//ターゲット地点をプレーヤーポジションに設定
		//destPos = player.position;
		
		//砲台は常にプレーヤーに向きます。
		//Transform turret = npc.GetComponent<EnemyController>().turret;
		//Quaternion turretRotation = Quaternion.LookRotation(destPos - turret.position);
		//turret.rotation = Quaternion.Slerp(turret.rotation, turretRotation, Time.deltaTime * curRotSpeed);
		
		//射撃
		npc.GetComponent<EnemyController>().ShootBullet();
	}
}
