using UnityEngine;
using System.Collections;

public class DefenseObjData : MonoBehaviour {

	public int DefObjHP = 10;
	private Light baseLight;

	// Use this for initialization
	void Start () {
		baseLight = GameObject.Find("BaseLight").GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	//何かに触れたとき
	void OnTriggerEnter(Collider CollisionObj){
		Debug.Log ("Hit!");
		if(CollisionObj.gameObject.tag == "Enemy"){
			DefObjHP -= 1; 
			Debug.Log (DefObjHP);
			Destroy(CollisionObj.gameObject);
		}

		if((DefObjHP < 7) && (3 < DefObjHP )){
			renderer.material.color = Color.yellow;
			baseLight.color = Color.yellow;
			baseLight.range = 15.0f;
			particleSystem.startColor = Color.yellow;

		}

		else if(DefObjHP < 3){
			renderer.material.color = Color.red;
			baseLight.color = Color.red;
			baseLight.range = 30.0f;
			particleSystem.startColor = Color.red;
		}
	}
}
