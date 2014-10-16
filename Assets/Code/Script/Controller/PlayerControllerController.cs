using UnityEngine;
using System;

namespace Limone{
	
	[Serializable]
	public class PlayerControllerController{

		public IPlayerController Playercontroller;

		public void SetPlayerControllerController(IPlayerController playercontroller){
			this.Playercontroller = playercontroller;
		}

		public void GetPlayerControllerController(){
		}
	}
}
