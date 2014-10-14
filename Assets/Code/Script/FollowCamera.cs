using UnityEngine;
using System.Collections;

namespace Limone{
	public class FollowCamera : MonoBehaviour,IFollowCameraController {

		public float betweenPlayer = 15.0f;
		public float height = 5.0f;
		public FollowCameraController follocamcontroller;

		private Transform playerpos;

		public void OnEnable(){
			
		}

		// Use this for initialization
		void Start () {
			FollowCamInit();
		}
		
		// Update is called once per frame
		void Update () {
			transform.position = playerpos.position + new Vector3(0.0f,height,-betweenPlayer);
			transform.LookAt(playerpos);
		}

		public void CameraChange(bool Cposbool){
			if(Cposbool){
				height = 5.0f;
			}
			else{
				height = -1.0f;
			}
		}

		public void FollowCamInit(){
			playerpos = GameObject.Find("Player").transform;	
		}

		public void GetPlayerPos(){
		}
	}
}
