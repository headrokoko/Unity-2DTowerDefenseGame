using UnityEngine;
using System.Collections;
public class FloorTrapState : AttackStateManager {
	private GameObject FTrap;
	public FloorTrapState(GameObject ftrap){
		FTrap = ftrap;
	}
	public void PutTrap(Vector3 putpos){
		Instantiate(FTrap, putpos ,FTrap.transform.rotation);
	}
}