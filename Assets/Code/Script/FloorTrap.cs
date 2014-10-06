using UnityEngine;
using System.Collections;

namespace Limone{
	public class FloorTrap : MonoBehaviour {

		public float BackPow = 500;
		public float UpPow = 500;
		public float ReloadTime = 3.0f;
		private bool trap = true;
		private bool TrapBool = false;
		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		}
		//何かに触れたとき
		void OnTriggerStay(Collider CollisionObj){
			//Debug.Log ("OnTrap");
			if((CollisionObj.gameObject.tag == "Enemy") && trap){
				trap = false;
				TrapBool = true;
				//Debug.Log ("TrapOn");
				GetComponent<Animator>().SetBool("OnTrap",TrapBool);
				//接触したEnemyを飛ばす
				CollisionObj.rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
				CollisionObj.transform.rigidbody.AddForce((Vector3.back * BackPow) + (Vector3.up * UpPow));
				CollisionObj.rigidbody.useGravity = true;
				CollisionObj.collider.isTrigger = true;
				StartCoroutine("Reload");
				//clone = Instantiate(PushWall,transform.position,transform.rotation) as Rigidbody;
				//clone.transform.Translate(0,1.0f,1.6f);
				//clone.velocity = transform.TransformDirection(Vector3.back * Pow);

			}
		}

		IEnumerator Reload(){
			//Debug.Log ("Reload");
			yield return new WaitForSeconds(ReloadTime);
			trap = true;
			TrapBool = false;
			GetComponent<Animator>().SetBool("OnTrap",TrapBool);
			//Debug.Log("trapready");
		}
	}
}