using UnityEngine;
using System.Collections;

namespace Limone{
	public class GameManagerIntegrationTest : MonoBehaviour {

		public bool Floorcollision = false;
		public bool CameraRender = false;
		public bool ParentCheck = false;
		public bool ChildrenCheck = false;
		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
			if(Floorcollision & CameraRender & ParentCheck & ChildrenCheck){
				IntegrationTest.Pass(gameObject);				
			}
		}
	}
}
