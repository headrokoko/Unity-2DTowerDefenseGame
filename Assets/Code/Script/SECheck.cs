using UnityEngine;
using System.Collections;

namespace Limone{
	public class SECheck : MonoBehaviour {

		public AudioClip EnemyDownSE;
		public AudioClip GunShotSE;
		public AudioClip PutTrapSE;
		public AudioClip StartSE;

		private GameManagerIntegrationTest inttest;

		// Use this for initialization
		void Start () {
			inttest = gameObject.GetComponent<GameManagerIntegrationTest>();
			if((EnemyDownSE != null) &
			   (GunShotSE != null) &
			   (PutTrapSE != null) &
			   (StartSE != null)){
				inttest.AudioCheck = true;
			}
		}	
	}
}
