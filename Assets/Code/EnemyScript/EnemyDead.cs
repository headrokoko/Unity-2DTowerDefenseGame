using UnityEngine;
using System.Collections;

namespace Limone{
	public class EnemyDead : EnemyFSMState {
		private GameData gameData;

		public EnemyDead(){
			stateID = FSMStateID.Dead;
			gameData = GameObject.Find("GameManager").GetComponent<GameData>();
		}
	
		public override void Reason(Transform player, Transform npc)
		{
		}
	
		public override void Act(Transform player, Transform npc, Transform target)
		{
		}
	}
}
