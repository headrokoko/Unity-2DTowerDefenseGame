using UnityEngine;
using Assets.Code.States;

namespace Assets.Code.States{
public class GunShotState : AttackStateManager {

	public int FireFlameRate;
	private int count = 0;
	private AttackStateManager Amanager;
	// Use this for initialization

	public GunShotState(AttackStateManager attackManager){
		Amanager = attackManager;
	}


	public void StateUpdata () {
		if((Input.GetKeyDown(KeyCode.Mouse0)) && (FireFlameRate <= count)){
			Fire();
		}

	}
	
	void Fire(){
		Rigidbody bul;
		bul = Instantiate(Bullet, transform.position, transform.rotation) as Rigidbody;
		bul.velocity = transform.TransformDirection(Vector3.right * 10);
		count = 0;
	}
}
}
