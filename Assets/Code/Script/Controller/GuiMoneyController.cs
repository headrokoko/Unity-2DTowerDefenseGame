using UnityEngine;
using System;

namespace Limone{
	
	[Serializable]
	public class GuiMoneyController{
		
		public IGUIMoneyController moneyController;
		
		public GuiMoneyController(){
		}
		
		public void SetGuiMoneyController(IGUIMoneyController moneyController){
			this.moneyController = moneyController;
		}
		
		public string GetMoneyText(int money){
			return "Money :" + money.ToString();
		}
		
	}
}
