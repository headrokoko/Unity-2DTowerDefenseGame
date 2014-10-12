using UnityEngine;
using System.Collections;
using Limone;

namespace Limone{
	public class GuiMoney : MonoBehaviour,IGUIMoneyController {
		
		private GameData gameData;
		
		// Use this for initialization
		public GuiMoneyController controller;
		
		public void OnEnable(){
			//下のthisにはインターフェース(IGUIMoneyController)が入る
			controller.SetGuiMoneyController(this);
		}
		
		void Start () {
			MoneyInit();
		}
		
		//Update is called once per frame
		//中継スクリプト(GuiMoneyController)から値を持ってきている
		void Update () {
			guiText.text = controller.GetMoneyText(gameData.Money);
		}
		
		public string FormatMoney(){
			return controller.GetMoneyText(GetGameData());
		}
		
		public int GetGameData(){
			return gameData.Money;
		}
		
		public void MoneyInit(){
			gameData = GameObject.Find("GameManager").GetComponent<GameData>();
		}
	}
}