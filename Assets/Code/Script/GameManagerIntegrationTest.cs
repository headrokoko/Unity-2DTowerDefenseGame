using UnityEngine;
using System.Collections;

namespace Limone{
	public class GameManagerIntegrationTest : MonoBehaviour {

		public bool Floorcollision = false;
		public bool CameraRender = false;
		public bool ParentCheck = false;
		public bool ChildrenCheck = false;
		public bool EnemyStateCheck = false;
		public bool PlayerDamageCheck = false;
		public bool MouseFlatteryCheck = false;
		public bool BackGroundTextureCheck = false;
		public bool AudioCheck = false;

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
			if(Floorcollision & 
			   CameraRender & 
			   ParentCheck & 
			   ChildrenCheck &
			   EnemyStateCheck &
			   PlayerDamageCheck &
			   MouseFlatteryCheck &
			   BackGroundTextureCheck &
			   AudioCheck
			   ){
				IntegrationTest.Pass(gameObject);				
			}
		}
	}
}
