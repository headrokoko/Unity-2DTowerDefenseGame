using UnityEngine;
using System.Collections;

public class DefenseObjData : MonoBehaviour {

	public int DefObjHP = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	//何かに触れたとき
	void OnTriggerEnter(Collider CollisionObj){
		Debug.Log ("Hit!");
		if(CollisionObj.gameObject.tag == "Enemy"){
			DefObjHP = DefObjHP - 1; 
			Debug.Log (DefObjHP);
			Destroy(CollisionObj.gameObject);
		}
	}
}
