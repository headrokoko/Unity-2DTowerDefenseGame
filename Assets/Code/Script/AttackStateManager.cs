using UnityEngine;
using Assets.Code.States;

public class AttackStateManager : MonoBehaviour {


	public AttackStateManager actAttackState;
	public Rigidbody Bullet;
	public GameObject Floor;
	public GameObject Wall;
	public GameObject Loof;
	private GameObject Weapon;

	

	// Use this for initialization
	void Start () { 
		actAttackState = new GunShotState(this);
	}
	
	// Update is called once per frame
	void Update () {
		if(actAttackState != null){
			actAttackState.Update();
		}
	}

	public void AttackChange(AttackStateManager newAttack){
		actAttackState = newAttack;
		Debug.Log("Atack mode ;" + actAttackState);
	}

}
