using UnityEngine;
using System;

namespace Limone{
	
	[Serializable]
	public class DefenseObjController{
		
		public IDefenseObjDataController Defcontroller;
		
		public DefenseObjController(){
		}
		
		public void SetDefenseObjController(IDefenseObjDataController defcontroller){
			this.Defcontroller = defcontroller;
		}
		
	}
}
