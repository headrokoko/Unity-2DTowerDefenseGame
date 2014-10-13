using UnityEngine;
using System.Collections;

namespace Limone{
	public class DefenseObjData : MonoBehaviour,IDefenseObjDataController {

		private Light baseLight;
		private GameData gameData;
		public DefenseObjController defcontroller;

		public void OnEnable(){
			//下のthisにはインターフェース(IGUIBaseHPController)が入る
			defcontroller.SetDefenseObjController(this);
		}
		// Use this for initialization
		void Start () {
			DefenseObjContInit();
		}
		
		// Update is called once per frame
		void Update () {

		}
		
		//何かに触れたとき
		void OnTriggerEnter(Collider CollisionObj){
			Debug.Log ("Hit!");
			if(CollisionObj.gameObject.tag == "Enemy"){
				gameData.BaseHP -= 1;
				Debug.Log (gameData.BaseHP);
				Destroy(CollisionObj.gameObject);
			}

			if((gameData.BaseHP < 7) && (3 < gameData.BaseHP )){
				renderer.material.color = Color.yellow;
				baseLight.color = Color.yellow;
				baseLight.range = 15.0f;
				particleSystem.startColor = Color.yellow;

			}

			else if(gameData.BaseHP < 3){
				renderer.material.color = Color.red;
				baseLight.color = Color.red;
				baseLight.range = 30.0f;
				particleSystem.startColor = Color.red;
			}
		}
		
		public int GetGameData(){
			return gameData.BaseHP;
		}
		
		public void DefenseObjContInit(){
			baseLight = GameObject.Find("BaseLight").GetComponent<Light>();
			gameData = GameObject.Find("GameManager").GetComponent<GameData>();
		}
	}
}
