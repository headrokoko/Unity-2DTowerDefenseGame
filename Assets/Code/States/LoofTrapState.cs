using UnityEngine;
using System.Collections;

namespace Limone{
	public class LoofTrapState : AttackStateManager {

		private GameObject LTrap;
		private AudioClip putSE;
		private AudioSource putsound;

		public LoofTrapState(GameObject ltrap,AudioClip se){
			LTrap = ltrap;
			putSE = se;
			putsound = GameObject.Find("Player").GetComponent<AudioSource>();
		}
		public void PutTrap(Vector3 putpos){
			Instantiate(LTrap, putpos ,LTrap.transform.rotation);
			putsound.PlayOneShot(putSE);
		}
	}
}