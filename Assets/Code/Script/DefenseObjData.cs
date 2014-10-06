using UnityEngine;
using System.Collections;

namespace Limone{
	public class DefenseObjData : MonoBehaviour {

		private Light baseLight;
		private GameData gamedata;

		// Use this for initialization
		void Start () {
			baseLight = GameObject.Find("BaseLight").GetComponent<Light>();
			gamedata = GameObject.Find("GameManager").GetComponent<GameData>();
		}
		
		// Update is called once per frame
		void Update () {

		}
		
		//何かに触れたとき
		void OnTriggerEnter(Collider CollisionObj){
			Debug.Log ("Hit!");
			if(CollisionObj.gameObject.tag == "Enemy"){
				gamedata.BaseHP -= 1;
				Debug.Log (gamedata.BaseHP);
				Destroy(CollisionObj.gameObject);
			}

			if((gamedata.BaseHP < 7) && (3 < gamedata.BaseHP )){
				renderer.material.color = Color.yellow;
				baseLight.color = Color.yellow;
				baseLight.range = 15.0f;
				particleSystem.startColor = Color.yellow;

			}

			else if(gamedata.BaseHP < 3){
				renderer.material.color = Color.red;
				baseLight.color = Color.red;
				baseLight.range = 30.0f;
				particleSystem.startColor = Color.red;
			}
		}
	}
}
