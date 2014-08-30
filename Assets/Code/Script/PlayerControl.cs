using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float playerSpeed;
	public float JumpPower;
	private float Movepow;
	private float MovePowMin = 2;
	private bool OnFloor = false;
	CapsuleCollider BodyColider;


	void Awake(){
		this.BodyColider = GetComponent<CapsuleCollider>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if((Input.anyKey) & OnFloor){
			//スペース押したらジャンプ
			if(Input.GetKeyDown(KeyCode.Space)){
				rigidbody.AddForce(Vector3.up * JumpPower);
			}
			//画面左右の動き
			Movepow = MovePowMin + Input.GetAxis("Horizontal") * playerSpeed;
			rigidbody.AddForce(Movepow,0,0);
		}
	}



	//Floorに着地したとき
	void OnCollisionEnter(Collision CollisionObj){
		if(CollisionObj.gameObject.tag == "Floor"){
			Debug.Log("ONFloor");
			OnFloor = true;
		}
	}
	//Floor上にいるとき
	void OnCollisionStay(Collision CollisionObj){
		if(CollisionObj.gameObject.tag == "Floor"){
			//Debug.Log("KeepFloor");
			OnFloor = true;
		}
	}
	//Floorから離れたとき
	void OnCollisionExit(Collision CollisionObj){
		if(CollisionObj.gameObject.tag == "Floor"){
			//Debug.Log("TakeOffFloor");
			OnFloor = false;
		}
	}
}
