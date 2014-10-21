using UnityEngine;
using System.Collections;

namespace Limone{
	public class PutTrapState : AttackStateManager {

		private AudioSource putsound;
		private AudioClip putse;
		private GameObject floortrap;
		private GameObject walltrap;
		private GameObject looftrap;

		public PutTrapState(GameObject floor,GameObject wall,GameObject loof,AudioClip se){
			floortrap = floor;
			walltrap = wall;
			looftrap = loof;
			putse = se;
			putsound = GameObject.Find("Player").GetComponent<AudioSource>();
		}

		public void PutFloorTrap(Vector3 putpos){
			Instantiate(floortrap,putpos,floortrap.transform.rotation);
			putsound.PlayOneShot(putse);
		}

		public void PutWallTrap(Vector3 putpos){
			Instantiate(walltrap,putpos,walltrap.transform.rotation);
			putsound.PlayOneShot(putse);
		}

		public void PutLoofTrap(Vector3 putpos){
			Instantiate(looftrap,putpos,looftrap.transform.rotation);
			putsound.PlayOneShot(putse);
		}
	}
}
