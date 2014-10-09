using UnityEngine;
using System.Collections;

namespace Limone{

	public class GuiScoreController{

		public IGUIScoreController scoreController;

		public GuiScoreController(){
		}

		public void SetGuiScoreController(IGUIScoreController scorecontroller){
			this.scoreController = scorecontroller;
		}

		public string GetScoreText(int score){
			return "score :" + score.ToString();
		}
	}
}
