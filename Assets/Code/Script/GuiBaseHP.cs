using UnityEngine;
using System.Collections;
using Limone;

namespace Limone{
	public class GuiBaseHP : MonoBehaviour,IGUIBaseHPController {
		
		private GameData gameData;
		public GUIText BaseHPText;
		
		// Use this for initialization
		public GuiBaseHPController controller;
		
		public void OnEnable(){
			//下のthisにはインターフェース(IGUIBaseHPController)が入る
			controller.SetGuiBaseHPController(this);
		}
		
		void Start () {
			BaseHPInit();
		}
		
		//Update is called once per frame
		//中継スクリプト(GuiBaseHPController)から値を持ってきている
		void Update () {
			//guiText.text = gameData.baseHP.ToString();
			guiText.text = controller.GetBaseHPText(gameData.BaseHP);
		}
		
		public string FormatBaseHP(){
			return controller.GetBaseHPText(GetGameData());
		}
		
		public int GetGameData(){
			return gameData.BaseHP;
		}
		
		public void BaseHPInit(){
			gameData = GameObject.Find("GameManager").GetComponent<GameData>();
		}
	}
}