using UnityEngine;
using System.Collections;

namespace Limone{
	public class GuiScore : MonoBehaviour,IGUIScoreController {

		private GameData gameData;
		// Use this for initialization
		public GuiScoreController controller;

		public void OnEnable(){
			//下のthisにはインターフェース(IGUIScoreController)が入る
			controller.SetGuiScoreController(this);
		}

		void Start () {
			ScoreInit();
		}
		
		// Update is called once per frame
		//　中継スクリプト(GuiScoreController)から値を持ってきている
		void Update () {
			//guiText.text = gameData.score.ToString();
			guiText.text = controller.GetScoreText(gameData.score);
		}

		public string FormatScore(){
			return controller.GetScoreText(GetGameData());
		}

		public int GetGameData(){
			return gameData.score;
		}

		public void ScoreInit(){
			gameData = GameObject.Find("GameManager").GetComponent<GameData>();
		}
	}
}