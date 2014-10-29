using UnityEngine;
using System.Collections;

namespace Limone{
	public class LoofGas : MonoBehaviour,ILoofGasController {

		public GameObject gasObj;
		public bool gasbool = true;
		public float ReloadTime = 10.0f;

		public LoofGasController loofgas;

		public void OnEnable(){
			loofgas.SetLoofGasController(this);
		}

		void OnTriggerEnter(Collider collider){
			if((collider.gameObject.tag == "Enemy") && gasbool){
				IntegrationTest.Pass(gameObject);
				Debug.Log("LoofGas ON");
				Transform putpos = transform;
				Instantiate(gasObj, putpos.position + new Vector3(0.0f,-2.0f,0.0f),putpos.rotation);
				particleSystem.Play();
				gasbool = false;
				StartCoroutine("Reload");
			}

		}
		
		IEnumerator Reload(){
			Debug.Log ("Reload");
			yield return new WaitForSeconds(ReloadTime);
			gasbool = true;
			Debug.Log("LoofGas Ready");
			particleSystem.Stop();
		}

		public void LoofGasInit(){
		}
	}
}