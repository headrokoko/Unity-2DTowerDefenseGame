using UnityEngine;
using System;

namespace Limone{

	[Serializable]
	public class StateManagerController{

		public IStateManagerController Statecontroller;
		public GameStateManager statemanager;

		public StateManagerController(){
			statemanager = new GameStateManager();
		}

		public void SetStateManagerController(IStateManagerController statemanagercontroller){
			this.Statecontroller = statemanagercontroller;
		}

		public string GetStateName(){
			string statename = statemanager.activeState.ToString();
			return statename;
		}

	}
}
