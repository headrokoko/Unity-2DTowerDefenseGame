using UnityEngine;
using System.Collections;

namespace Limone{
	public class FloorTrapState : AttackStateManager {
		private GameObject FTrap;
		private AudioClip putSE;
		private AudioSource putsound;

		public FloorTrapState(GameObject trap,AudioClip se){
			FTrap = trap;
			putSE = se;
			putsound = GameObject.Find("Player").GetComponent<AudioSource>();
		}
		public void PutTrap(Vector3 putpos){
			Instantiate(FTrap, putpos ,FTrap.transform.rotation);
			putsound.PlayOneShot(putSE);
		}
	}
}