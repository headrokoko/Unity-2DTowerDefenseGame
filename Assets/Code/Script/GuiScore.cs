using UnityEngine;
using System.Collections;

namespace Limone {

	public class GuiScore : MonoBehaviour, IGeneralController {

		private GameData gameData;
		// Use this for initialization

		public GuiScoreController controller;

		public void OnEnable() {
			controller.SetGuiScoreController (this);
		}

		void Start () {
			GenericInit ();
		}

		// Update is called once per frame
		void Update () {
			guiText.text = controller.GetScoreText(gameData.score);
		}

		public string FormatScore(){
			return controller.GetScoreText (GetGameData());
		}

		public int GetGameData() {
			return gameData.score;
		}

		public void GenericInit() {
			gameData = GameObject.Find("GameManager").GetComponent<GameData>();	
		}

	}

}