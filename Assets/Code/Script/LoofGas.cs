using UnityEngine;
using System.Collections;

namespace Limone{
	public class LoofGas : MonoBehaviour {

		public GameObject gasObj;
		public bool gasbool = true;
		public float ReloadTime = 10.0f;
		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		}

		void OnTriggerEnter(Collider collider){
			if((collider.gameObject.tag == "Enemy") && gasbool){
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
	}
}