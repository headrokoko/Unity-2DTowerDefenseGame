using UnityEngine;
using System.Collections;

public class LoofTrapState : AttackStateManager {

	private GameObject LTrap;

	public LoofTrapState(GameObject ltrap){
		LTrap = ltrap;
	}
	public void PutTrap(Vector3 putpos){
		Instantiate(LTrap, putpos ,LTrap.transform.rotation);
	}
}
