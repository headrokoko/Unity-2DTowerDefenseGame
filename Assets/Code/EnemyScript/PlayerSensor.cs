using UnityEngine;
using System.Collections;

public class PlayerSensor : MonoBehaviour {

	public Transform Target;
	public float Range = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Vector3 loolup = transform.position + ((Vector3.right *5) + (Vector3.up * 5));
		if((Physics.Raycast(transform.position,Vector3.right,out hit,Range))||
		   (Physics.Raycast(transform.position,Vector3.right + Vector3.up,out hit,Range)))
		   {
			if(hit.collider.tag == "Player"){
			Debug.Log ("Player視認");
			}
		}
	
	}

	void OnDrawGizmos(){
		Vector3 frontend = transform.position + (transform.right * Range) ;
		Vector3 loolup = transform.position + ((Vector3.right *5) + (Vector3.up * 5));
		Debug.DrawLine(transform.position,frontend,Color.red);
		Debug.DrawLine(transform.position,loolup,Color.red);
	}
}
