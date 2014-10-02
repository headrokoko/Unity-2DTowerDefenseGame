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
	private GameData gameData;
	private int contactTime;
	private GameObject UnityChan;
	
	void Awake(){

	}
	
	// Use this for initialization
	void Start () {
		gameData = GameObject.Find("GameManager").GetComponent<GameData>();
		UnityChan = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		count++;
		
		if((Input.anyKey) & OnFloor){
			//スペース押したらジャンプ
			if(Input.GetKeyDown(KeyCode.Space)){
				rigidbody.AddForce(Vector3.up * JumpPower);
				UnityChan.GetComponent<Animator>().SetBool("JumpOn",true);
			}
		}
			//画面左右の動き
			if(Input.GetKey(KeyCode.D)){
			transform.Translate(Movepow,0,0);
			transform.eulerAngles = new Vector3 (0,0,0); 
			UnityChan.GetComponent<Animator>().SetBool("RunOn",true);
			UnityChan.transform.position = new Vector3(transform.position.x,transform.position.y - 1.0f,transform.position.z);
			}

		else if (Input.GetKey(KeyCode.A)){
			transform.Translate(Movepow,0,0);
			transform.eulerAngles = new Vector3 (0,180,0); 
			UnityChan.GetComponent<Animator>().SetBool("RunOn",true);
			UnityChan.transform.position = new Vector3(transform.position.x,transform.position.y - 1.0f,transform.position.z);
		}

		else {
		UnityChan.GetComponent<Animator>().SetBool("RunOn",false);
		}
	}
	void OnTriggerStay(Collider collider){
		if((collider.gameObject.tag == "Enemy")&&(contactTime == 0)){
			gameData.playerHP -= 1;
			UnityChan.GetComponent<Animator>().SetBool("DamageOn",true);
		}
		contactTime++;

		if(contactTime >= 60){
			contactTime = 0;
		}
	}

	void OnTriggerExit(Collider collider){
		if(collider.gameObject.tag == "Enemy"){
			contactTime = 0;
			UnityChan.GetComponent<Animator>().SetBool("DamageOn",false);
		}
	}

	//何かに触れたとき
	void OnCollisionEnter(Collision CollisionObj){
		if(CollisionObj.gameObject.tag == "Floor"){
			UnityChan.GetComponent<Animator>().SetBool("JumpOn",false);
			UnityChan.GetComponent<Animator>().SetBool("FallOn",false);
			//Debug.Log("ONFloor");
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
			UnityChan.GetComponent<Animator>().SetBool("FallOn",true);
		}
	}

	void Fire(){
		Rigidbody bullet;
		bullet = Instantiate(Bullet, transform.position, transform.rotation) as Rigidbody;
		bullet.velocity = transform.TransformDirection(Vector3.right * 10);
		count = 0;
	}
}
