﻿using UnityEngine;
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
		private GameManagerIntegrationTest inttest;

		public MouseFlattery(){
		}

		void Start(){
			MouseFlatttryInit();
		}

		// Update is called once per frame
		void Update () {
			//var CameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			//mouseoverobj = cameraRayHit.collider.gameObject;
			AlphaSwhich();
			GetScreenPos();
			gameObject.transform.position = screenpos;

		}

		public void AlphaSwhich(){
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
		}

		public void GetScreenPos(){
			mousepos = Input.mousePosition;
			mousepos.z = offset;
			screenpos = Camera.main.ScreenToWorldPoint(mousepos);
		}

		public void MouseFlatttryInit(){
			attackstate = GameObject.Find("Player").GetComponent<AttackStateManager>();
			inttest = GameObject.Find("GameManager").GetComponent<GameManagerIntegrationTest>();
			floor = GameObject.Find("SpringTrapBase").GetComponent<SkinnedMeshRenderer>();
			wall = GameObject.Find("BladeWall.001").GetComponent<SkinnedMeshRenderer>();
			loof = GameObject.Find("LoofGas").GetComponent<MeshRenderer>();
			if((floor != null)&
			   (wall != null)&
			   (loof != null)){
				inttest.MouseFlatteryCheck = true;
			}
		}
	
	}
}
