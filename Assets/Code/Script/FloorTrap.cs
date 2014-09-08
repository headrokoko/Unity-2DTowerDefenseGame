using UnityEngine;
using System.Collections;

public class FloorTrap : MonoBehaviour {

	public float Pow = 500;
	public Rigidbody PushWall;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	//何かに触れたとき
	void OnTriggerEnter(Collider CollisionObj){
		Debug.Log ("OnTrap");
		if(CollisionObj.gameObject.tag == "Enemy"){
			Debug.Log ("TrapOn");
			Rigidbody clone;
			clone = Instantiate(PushWall,transform.position,transform.rotation) as Rigidbody;
			clone.transform.Translate(0,1.0f,1.6f);
			clone.velocity = transform.TransformDirection(Vector3.back * Pow);

		}
	}
}