using UnityEngine;
using System.Collections;

namespace Limone{
	public class PlayerRenderTest : MonoBehaviour {

		void OnBecameVisible(){
			IntegrationTest.Pass(gameObject);
		}
	}
}
