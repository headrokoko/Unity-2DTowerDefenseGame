using UnityEngine;
using Assets.Code.States;

namespace Assets.Code.States{
	public class GunShotState : AttackStateManager {

		public int FireFlameRate;
		private int count = 0;
		private AttackStateManager Amanager;
		private Transform PlayerPos; 
		private Rigidbody Bul;
		// Use this for initialization

		public GunShotState(Rigidbody bullet){
			Bullet = bullet;
		}


		public void GunAction (Transform Player) {
			if((Input.GetKeyDown(KeyCode.Mouse0)) && (FireFlameRate <= count)){
				PlayerPos = Player;
				Debug.Log("Gun shot");
				Fire();
			}
		}
	
		void Fire(){
			Rigidbody bul;
			bul = Instantiate(Bullet, PlayerPos.position, PlayerPos.rotation) as Rigidbody;
			bul.velocity = PlayerPos.TransformDirection(Vector3.right * 10);
			count = 0;
		}
	}
}
