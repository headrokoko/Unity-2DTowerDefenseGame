using UnityEngine;
using System;

namespace Limone{
	[Serializable]
	public class FloorTrapController{

		public IFloorTrapController Floorctrapcontroll;

		public FloorTrapController(){
		}

		public void SetFloorTrapController(IFloorTrapController floortrapcontroller){
			this.Floorctrapcontroll = floortrapcontroller;
		}

		public void GetFloorTrapController(){
		}
	}
}
