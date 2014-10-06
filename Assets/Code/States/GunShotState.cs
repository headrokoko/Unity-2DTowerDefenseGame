using UnityEngine;
using Limone;

namespace Limone{
	public class GunShotState : AttackStateManager {

		private int firerate;
		private int count = 0;
		private AttackStateManager Amanager;
		private Transform PlayerPos; 
		private Rigidbody Bul;
		private AudioClip SE;
		private AudioSource GunSe;
		// Use this for initialization

		public GunShotState(Rigidbody bullet,int rate,AudioClip gunse){
			Bullet = bullet;
			firerate = rate;
			SE = gunse;
			GunSe = GameObject.Find("Player").GetComponent<AudioSource>();
		}


		public void GunAction (Transform Player) {
			count++;
			if((Input.GetKeyDown(KeyCode.Mouse0)) && (firerate <= count)){
				PlayerPos = Player;
				count = 0;
				//Debug.Log("Gun shot");
				Fire();
			}
		}
	
		void Fire(){
			Rigidbody bul;
			Debug.Log(SE);
			GunSe.PlayOneShot(SE);
			bul = Instantiate(Bullet, PlayerPos.position, PlayerPos.rotation) as Rigidbody;
			bul.velocity = PlayerPos.TransformDirection(Vector3.right * 10);
			count = 0;
		}
	}
}
