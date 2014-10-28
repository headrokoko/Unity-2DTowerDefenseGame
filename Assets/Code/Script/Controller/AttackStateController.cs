using UnityEngine;
using System;

namespace Limone{
	[Serializable]
	public class AttackStateController{
		
		public IAttackStateController Attackstatecontroller;
		public AttackStateManager attackstatemanager;
		
		public AttackStateController(){
			attackstatemanager = new AttackStateManager();
		}
		
		public void SetAttackStateManagerController(IAttackStateController attackstatemanagercontroller){
			this.Attackstatecontroller = attackstatemanagercontroller;
		}

		public Vector3 GetClickPos(){
			return attackstatemanager.mousepos;
		}
		
		public string GetAttackStateName(string newstate){
			return newstate.ToString();
		}
	}
}
