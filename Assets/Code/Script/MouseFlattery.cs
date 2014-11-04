using UnityEngine;
using System.Collections;

namespace Limone{
	public class MouseFlattery : MonoBehaviour {

		public Vector3 mousepos;
		public Vector3 screenpos;

		private SkinnedMeshRenderer floor;
		private SkinnedMeshRenderer wall;
		private MeshRenderer loof;
		private RaycastHit cameraRayHit;
		//private GameObject mouseoverobj;
		public float offset = 15.0f;

		private AttackStateManager attackstate;

		public MouseFlattery(){
		}

		void Start(){
			attackstate = GameObject.Find("Player").GetComponent<AttackStateManager>();
			floor = GameObject.Find("SpringTrapBase").GetComponent<SkinnedMeshRenderer>();
			wall = GameObject.Find("BladeWall.001").GetComponent<SkinnedMeshRenderer>();
			loof = GameObject.Find("LoofGas").GetComponent<MeshRenderer>();
		}

		// Update is called once per frame
		void Update () {
			//var CameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			//mouseoverobj = cameraRayHit.collider.gameObject;
			if((attackstate.weaponNum == 1)){
				floor.enabled = true;
				wall.enabled = false;
				loof.enabled = false;
			}
			else if(attackstate.weaponNum == 2){
				floor.enabled = false;
				wall.enabled = true;
				loof.enabled = false;
			}
			else if(attackstate.weaponNum == 3){
				floor.enabled = false;
				wall.enabled = false;
				loof.enabled = true;
			}
			else{
				floor.enabled = false;
				wall.enabled = false;
				loof.enabled = false;
			}
			mousepos = Input.mousePosition;
			mousepos.z = offset;
			screenpos = Camera.main.ScreenToWorldPoint(mousepos);

			gameObject.transform.position = screenpos;

		}
	
	}
}
