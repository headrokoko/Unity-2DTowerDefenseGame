using UnityEngine;
using System;

namespace Limone {

	[Serializable]
	public class GuiScoreController
	{
		//public GUIText ScoreText;

		public IGeneralController generalController;

		public GuiScoreController (){
		}

		public void SetGuiScoreController(IGeneralController generalController) {
			this.generalController = generalController;
		}

		public string GetScoreText(int score) {
			return "Score :" + score.ToString ();
		}
	}


}
