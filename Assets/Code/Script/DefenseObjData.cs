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
	void OnCollisionEnter(Collision CollisionObj){
		Debug.Log ("Hit!");
		if(CollisionObj.gameObject.tag == "Player"){
			DefObjHP = DefObjHP - 1; 
			Debug.Log (DefObjHP);
		}
	}
}
