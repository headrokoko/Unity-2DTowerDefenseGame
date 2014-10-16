using UnityEngine;
using System;

namespace Limone{
	[Serializable]
	public class AttackStateController{
		
		public IAttackStateController Attackstatecontroller;
		
		public AttackStateController(){
		}
		
		public void SetAttackStateManagerController(IAttackStateController attackstatemanagercontroller){
			this.Attackstatecontroller = attackstatemanagercontroller;
		}
		
		public string GetAttackStateName(string newstate){
			return newstate.ToString();
		}
	}
}
