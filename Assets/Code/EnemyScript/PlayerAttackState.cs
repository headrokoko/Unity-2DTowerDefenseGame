using UnityEngine;
using System.Collections;

namespace Limone{
	public class PlayerAttackState : EnemyFSMState {
		public EnemyController enemycontoroller;
		public PlayerAttackState(Transform player){
			stateID = FSMStateID.PlayerAttack;
			moveSpeed = 1.0f;
			RotSpeed = 100.0f;
		}
	
	
		public override void Reason(Transform player, Transform npc)
		{
			RaycastHit hit;
			//Playerとnpcの間にFloorかLoofがある場合
			if(Physics.Raycast(npc.transform.position,npc.transform.forward,out hit,1.0f))
			{
				if((hit.collider.tag == "Floor")||(hit.collider.tag == "Loof" )){
					Debug.Log("PlayerLost Swich MarchState");
					npc.renderer.material.color = Color.white;
					npc.GetComponent<EnemyController>().SetTransition(Transition.LostPlayer);
				}
			}

			//プレーヤーとの距離を確認
			float between = Vector3.Distance(npc.position, player.position);
			//一定の距離内にPlayerがいなくなったらMarchstateに戻る
			if (between >= 10.0f)
			{
				Debug.Log("PlayerLost Swich MarchState");

				Transform npcChild = npc.FindChild("Enemymodel");
				npcChild.renderer.material.color =Color.white;
				npc.renderer.material.color = Color.white;
				npc.GetComponent<EnemyController>().SetTransition(Transition.LostPlayer);
			}  
		}
	
		public override void Act(Transform player, Transform npc, Transform target)
		{
			//Debug.Log("AttackState");
			RaycastHit floorHit;
			RaycastHit loofHit;
			Vector3 subTarget;
			//npcの下にfloorがあるか
			if(Physics.Raycast(npc.transform.position,npc.transform.up * -3,out floorHit,2)){
				subTarget = player.position;
				subTarget.y = npc.transform.position.y;
				npc.transform.LookAt(subTarget,Vector3.up);
			}
			//npcの頭上にLoofがあるか
			if(Physics.Raycast(npc.transform.position,npc.transform.up * 3 ,out loofHit,2)){
				subTarget = player.position;
				subTarget.y = npc.transform.position.y;
				npc.transform.LookAt(subTarget,Vector3.up);
			}
			else{
				npc.transform.LookAt(player,Vector3.up);
			}

			//ターゲットをプレイヤーに変更しそちらを向く
			npc.Translate(Vector3.forward * Time.deltaTime * moveSpeed * 2);

		}
	}
}
