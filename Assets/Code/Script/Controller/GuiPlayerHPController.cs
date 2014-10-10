using UnityEngine;
using System.Collections;

namespace Limone{

	public class GuiPlayerHPController {

		public IGUIPlayerHPController PlayerHPController;

		public GuiPlayerHPController(){
		}

		public void SetGuiPlayerHPController(IGUIPlayerHPController playerHPcontroller){
			this.PlayerHPController = playerHPcontroller;
		}

		public string GetPlayerHPText(int PlayerHP){
			return "PlayerHP :" + PlayerHP.ToString();
		}
	}
}
