using UnityEngine;
using System;

namespace Limone{
	
	[Serializable]
	public class GuiBaseHPController{
		
		public IGUIBaseHPController baseHPController;
		
		public GuiBaseHPController(){
		}
		
		public void SetGuiBaseHPController(IGUIBaseHPController baseHPController){
			this.baseHPController = baseHPController;
			Debug.Log("GuiBaseHPController this = " + this);
		}
		
		public string GetBaseHPText(int baseHP){
			return "BaseHP :" + baseHP.ToString();
		}
		
	}
}
