using UnityEngine;
using System;

namespace Limone{

	[Serializable]
	public class StateManagerController{

		public IStateManagerController Statecontroller;

		public StateManagerController(){
		}

		public void SetStateManagerController(IStateManagerController statemanagercontroller){
			this.Statecontroller = statemanagercontroller;
		}

		public string GetStateName(string newstate){
			return newstate.ToString();
		}

	}
}
