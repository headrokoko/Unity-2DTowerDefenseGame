using UnityEngine;
using System;

namespace Limone{
	[Serializable]
	public class BladeWallController{

		public IBladeWallController Bladewallcontroller;

		public BladeWallController(){
		}

		public void SetBladeWallController(IBladeWallController bladewallcontroller){
			this.Bladewallcontroller = bladewallcontroller;
		}

		public void GetBladeWallController(){
		}
	}
}
