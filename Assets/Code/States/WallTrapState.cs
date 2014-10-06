using UnityEngine;
using System.Collections;

namespace Limone{
	public class WallTrapState : AttackStateManager {

		private GameObject WTrap;
		private AudioClip putSE;
		private AudioSource putsound;

		public WallTrapState(GameObject trap,AudioClip se){
			WTrap = trap;
			putSE = se;
			putsound = GameObject.Find("Player").GetComponent<AudioSource>();
		}

		public void PutTrap(Vector3 putpos){
			Instantiate(WTrap, putpos ,WTrap.transform.rotation);
			putsound.PlayOneShot(putSE);
		}
	}
}
