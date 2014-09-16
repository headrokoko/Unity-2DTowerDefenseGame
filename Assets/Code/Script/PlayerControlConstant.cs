using UnityEngine;
using System.Collections;

public class PlayerControlConstant : MonoBehaviour {
	
	public float playerSpeed;
	public float JumpPower;
	private float Movepow;
	private bool OnFloor = false;
	
	
	void Awake(){

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
		}
			//画面左右の動き
			if(Input.GetKey(KeyCode.A)){
			transform.Translate(-Movepow,0,0);
			}

		else if (Input.GetKey(KeyCode.D)){
			transform.Translate(Movepow,0,0);
			}

	}
	//何かに触れたとき
	void OnCollisionEnter(Collision CollisionObj){
		if(CollisionObj.gameObject.tag == "Floor"){
			Debug.Log("ONFloor");
			Movepow = playerSpeed;
			OnFloor = true;
		}
		if(CollisionObj.gameObject.tag == "Death"){
			Debug.Log("GameOver");
		}

	}
	//Floor上にいるとき
	void OnCollisionStay(Collision CollisionObj){
		if(CollisionObj.gameObject.tag == "Floor"){
			//Debug.Log("KeepFloor");
			Movepow = playerSpeed;
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
