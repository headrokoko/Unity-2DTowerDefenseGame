using UnityEngine;
using System.Collections;

namespace Limone{
	public class CameraRenderTest : MonoBehaviour {

		public bool visible = false;

		void OnBecameVisible(){
			visible = true;
		}
		void OnBecameInvisible(){
			Destroy(this);
			if(visible)
				IntegrationTest.Pass(gameObject);
			else
				IntegrationTest.Fail(gameObject);
		}
	}
}
