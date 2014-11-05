using UnityEngine;
using System.Collections;

namespace Limone{
	public class GetChildrenObj : MonoBehaviour {

		public GameObject ChildPlayer;
		public GameObject ChildLight;
		public GameObject ChildScore;
		public GameObject ChildPlayerHP;
		public GameObject ChildFollorCamera;
		public GameObject ChildZoomOutCamera;
		public GameObject ChildMony;
		public GameObject ChildBaseHP; 
		public GameObject ChildMouseFlattery;

		private GameManagerIntegrationTest inttest;

		void Start(){
			inttest = GameObject.Find("GameManager").GetComponent<GameManagerIntegrationTest>();
			ChildPlayer = gameObject.transform.FindChild("Player").gameObject;
			ChildLight = gameObject.transform.FindChild("Directional light").gameObject;
			ChildScore = gameObject.transform.FindChild("Score").gameObject;			
			ChildPlayerHP = gameObject.transform.FindChild("Player HP").gameObject;
			ChildFollorCamera = gameObject.transform.FindChild("FollowCamera").gameObject;
			ChildZoomOutCamera = gameObject.transform.FindChild("ZoomOutCamera").gameObject;
			ChildMony = gameObject.transform.FindChild("Money").gameObject;
			ChildBaseHP = gameObject.transform.FindChild("Base HP").gameObject;
			ChildMouseFlattery = gameObject.transform.FindChild("MouseFlattery").gameObject;

			if((ChildPlayer != null) & 
			   (ChildLight != null) &
			   (ChildScore != null) &		   
			   (ChildPlayerHP != null) &
			   (ChildFollorCamera != null) &
			   (ChildZoomOutCamera != null) &
			   (ChildMony != null)&
			   (ChildBaseHP != null)&
			   (ChildMouseFlattery != null)){
				inttest.ChildrenCheck = true;
			}
		}
	
	}
}
