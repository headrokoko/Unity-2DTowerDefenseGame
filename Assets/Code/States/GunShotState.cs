using UnityEngine;
using Limone;

namespace Limone{
	namespace Assets.Code.States{
		public class GunShotState : AttackStateManager {

			private int firerate;
			private int count = 0;
			private AttackStateManager Amanager;
			private Transform PlayerPos; 
			private Rigidbody Bul;
			// Use this for initialization

			public GunShotState(Rigidbody bullet,int rate){
				Bullet = bullet;
				firerate = rate;
			}


			public void GunAction (Transform Player) {
				count++;
				if((Input.GetKeyDown(KeyCode.Mouse0)) && (firerate <= count)){
					PlayerPos = Player;
					count = 0;
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
}
