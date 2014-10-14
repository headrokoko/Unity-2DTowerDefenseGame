using UnityEngine;
using System;

namespace Limone{
	
	[Serializable]
	public class FollowCameraController{

		public IFollowCameraController Ifollowcam;

		public FollowCameraController(){
		}

		public void SetFollowCameraController(IFollowCameraController IFollowCam){
			this.Ifollowcam = IFollowCam;
		}

		public void GetPlayerPos(){
		}

	}
}
