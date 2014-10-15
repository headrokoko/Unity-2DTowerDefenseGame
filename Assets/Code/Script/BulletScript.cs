using UnityEngine;
using System.Collections;

namespace Limone{
	public class BulletScript : MonoBehaviour,IBulletController {

		public float DestroyTime = 3.0f;


		// Use this for initialization
		void Start () {
			BulletInit();		
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		void OnTriggerEnter(Collider collider){
			if(collider.gameObject.tag == "Enemy"){
				Destroy(this.gameObject);
			}
		}
		public void BulletInit(){
			Destroy(gameObject,DestroyTime);
		}
	}
}
