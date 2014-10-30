using UnityEngine;
using System.Collections;

namespace Limone{
	public class BladeWall : MonoBehaviour,IBladeWallController {

		public GameObject obj;
		public float ReloadTime = 3.0f;
		private bool trap = true;
		private bool TrapBool = false;

		public BladeWallController bladewallcontroller;

		
		public void OnEnable(){
			bladewallcontroller.SetBladeWallController(this);
		}

		void OnTriggerStay(Collider collider){
			if((collider.gameObject.tag == "Enemy") && trap){
				Debug.Log("BladeWall ON");
				trap = false;
				TrapBool = true;
				Transform putpos = transform;
				Instantiate(obj, putpos.position + new Vector3(0.0f,0.0f,-2.0f),putpos.rotation);
				GetComponent<Animator>().SetBool("OnTrap",TrapBool);
				//collider.GetComponent<EnemyController>().health -= damage;
				StartCoroutine("Reload");
			}
		}

		IEnumerator Reload(){
			//Debug.Log ("Reload");
			yield return new WaitForSeconds(ReloadTime);
			trap = true;
			TrapBool = false;
			GetComponent<Animator>().SetBool("OnTrap",TrapBool);
			Debug.Log("Walltrapready");
			Integration();
		}
		public void BladeWallInit(){
		
		}
		//リロード完了でテストをパス
		public void Integration(){
			if(trap){
				IntegrationTest.Pass(gameObject);
			}
			else{
				IntegrationTest.Fail(gameObject);
			}
		}
	}
}
