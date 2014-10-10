using UnityEngine;
using System.Collections;

namespace Limone{

	public class GuiScoreController{
		
		//public GUIText ScoreText;

		public IGUIScoreController scoreController;

		public GuiScoreController(){
		}

		public void SetGuiScoreController(IGUIScoreController scoreController){
			this.scoreController = scoreController;
		}

		public string GetScoreText(int score){
			Debug.Log("score ;;;" + score);
			return "score :" + score.ToString();
		}

	}
}
