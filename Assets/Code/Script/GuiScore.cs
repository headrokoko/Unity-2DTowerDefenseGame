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
			GenericInit();
		}
		
		// Update is called once per frame
		//　中継スクリプト(GuiScoreController)から値を持ってきている
		void Update () {
			guiText.text = controller.GetScoreText(gameData.score);
		}

		public string FormatScore(){
			return controller.GetScoreText(GetGameData());
		}

		public int GetGameData(){
			return gameData.score;
		}

		public void GenericInit(){
			gameData = GameObject.Find("GameManager").GetComponent<GameData>();
		}
	}
}