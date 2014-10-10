using UnityEngine;
using System.Collections;

namespace Limone{
	public class GuiPlayerHP : MonoBehaviour,IGUIPlayerHPController {

		private GameData gameData;

		public GuiPlayerHPController PlayerHPController;

		public void OnEnable(){
			//thisにはIGUIPlayerHPControllerが入る
			PlayerHPController.SetGuiPlayerHPController(this);
		}

		// Use this for initialization
		void Start () {
			PlayerHPInit();
		}
		// Update is called once per frame
		//　中継スクリプト(GuiPlayerHPController)から値を持ってきている
		void Update () {
			guiText.text = PlayerHPController.GetPlayerHPText(gameData.playerHP);
		}

		public string FormatPlayerHP(){
			return PlayerHPController.GetPlayerHPText(GetGameData());
		}
		
		public int GetGameData(){
			return gameData.score;
		}

		//GameDataからPlayerHPの引数を取る
		public void PlayerHPInit(){
			gameData = GameObject.Find("GameManager").GetComponent<GameData>();
		}
	}
}