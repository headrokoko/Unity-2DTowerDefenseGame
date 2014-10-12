using UnityEngine;
using System;

namespace Limone{

	[Serializable]
	public class GuiScoreController{

		public IGUIScoreController scoreController;

		public GuiScoreController(){
			Debug.Log("GuiScoreController this = " + this);
		}

		public void SetGuiScoreController(IGUIScoreController scoreController){
			this.scoreController = scoreController;
			Debug.Log("GuiScoreController this = " + this);
		}

		public string GetScoreText(int score){
			return "score :" + score.ToString();
		}

	}
}
