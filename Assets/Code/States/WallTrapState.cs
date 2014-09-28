using UnityEngine;
using System.Collections;

public class WallTrapState : AttackStateManager {

	private GameObject WTrap;

	public WallTrapState(GameObject trap){
		WTrap = trap;
	}

	public void PutTrap(Vector3 putpos){
		
		Instantiate(WTrap, putpos ,WTrap.transform.rotation);
	}
}
