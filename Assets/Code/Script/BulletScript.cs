using UnityEngine;
using System.Collections;

namespace Limone{
	public class BulletScript : MonoBehaviour {

		public float DestroyTime = 3.0f;


		// Use this for initialization
		void Start () {
			Destroy(gameObject,DestroyTime);
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		void OnTriggerEnter(Collider collider){
			if(collider.gameObject.tag == "Enemy"){
				Destroy(this.gameObject);
			}
		}
	}
}
