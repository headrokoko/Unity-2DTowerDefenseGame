using UnityEngine;
using System.Collections;

public class PlayerControlConstant : MonoBehaviour {
	
	public float playerSpeed;
	public float JumpPower;
	public Rigidbody Bullet;
	public int FireFlameRate;
	private int count = 0;
	private float Movepow;
	private bool OnFloor = false;

	
	
	void Awake(){

	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		count++;
		
		if((Input.anyKey) & OnFloor){
			//スペース押したらジャンプ
			if(Input.GetKeyDown(KeyCode.Space)){
				rigidbody.AddForce(Vector3.up * JumpPower);
			}
		}
			//画面左右の動き
			if(Input.GetKey(KeyCode.D)){
			transform.Translate(Movepow,0,0);
			transform.eulerAngles = new Vector3 (0,0,0); 
			}

		else if (Input.GetKey(KeyCode.A)){
			transform.Translate(Movepow,0,0);
			transform.eulerAngles = new Vector3 (0,180,0); 
		}

		if((Input.GetKeyDown(KeyCode.Mouse0)) && (FireFlameRate <= count)){
			Fire();
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

	void Fire(){
		Rigidbody bullet;
		bullet = Instantiate(Bullet, transform.position, transform.rotation) as Rigidbody;
		bullet.velocity = transform.TransformDirection(Vector3.right * 10);
		count = 0;
	}
}
