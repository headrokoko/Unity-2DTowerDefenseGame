using UnityEngine;
using System.Collections;

namespace Limone{
	public class FloorTrapState : AttackStateManager {
		private GameObject FTrap;
		public FloorTrapState(GameObject trap){
			FTrap = trap;
		}
		public void PutTrap(Vector3 putpos){
			Instantiate(FTrap, putpos ,FTrap.transform.rotation);
		}
	}
}