using UnityEngine;
using System.Collections;

namespace Limone{
	public class PlayerSensor : MonoBehaviour {

		public Transform Target;
		public Transform Player;
		public int EnemyHP = 5;
		public float Range = 5f;
		public float Speed = 0.01f;
		private GameData gameData;
		// Use this for initialization
		void Start () {
			gameData = GameObject.Find("GameManager").GetComponent<GameData>();	
		}

		// Update is called once per frame
		void Update () {
			RaycastHit hit;
			Vector3 loolup = transform.position + ((Vector3.right *5) + (Vector3.up * 5));

			transform.LookAt(Target,Vector3.up);
			transform.Translate(Vector3.forward * Speed);
			if(Physics.Raycast(transform.position,transform.forward,out hit,Range))
		   	{
				if(hit.collider.tag == "Player"){
					Debug.Log ("Player視認");
				}
			}
			if(Physics.Raycast(transform.position,transform.forward + transform.up,out hit,Range))
			{
				if(hit.collider.tag == "Player"){
					Debug.Log ("Player視認2");
				}
			}
			}
		void OnCollisionEnter(Collision CollisionObj){
			if(CollisionObj.gameObject.tag == "Defense"){
				Debug.Log ("Damage");
			}
			
			if(CollisionObj.gameObject.tag == "Dead"){
				gameData.score += 1;
				Destroy(this.gameObject);
			}
		}

		void OnDrawGizmos(){
			Vector3 frontend = transform.position + (transform.forward * Range) ;
			Vector3 loolup = transform.position + ((transform.forward *5) + (transform.up * 5));
			Debug.DrawLine(transform.position,frontend,Color.red);
			Debug.DrawLine(transform.position,loolup,Color.red);
		}
	}
}
