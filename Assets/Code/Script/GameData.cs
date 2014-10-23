using UnityEngine;
using System.Collections.Generic;

namespace Limone{
	public class GameData : MonoBehaviour,IGameDataController {
		
		// athenaeum test
		public Texture2D startTexture;
		public Texture2D menuTexture;
		public Texture2D stageselectTexture;
		//public Texture2D tradeTexture;
		public Texture2D resultTexture;
		
		public List<GameObject> cameras;
		
		public int initPlayerHP = 10;
		private int beginScore;

		public int playerHP = 10;
		[HideInInspector]
		public int BaseHP = 15;
		public int score = 0;
		public int Money = 1000;

		public GameDataController gamedatacontroller;

		public GameData(){
		}

		public void OnEnable(){
			//下のthisにはインターフェース(IGameDataController)が入る
			gamedatacontroller.SetGameDataController(this);
			Debug.Log(startTexture);
		}
		
		void Start() {
			GameDataInit();
		}

		void Update(){
			if(playerHP == 0){
				playerHP = gamedatacontroller.GetInitPlayerHP();
				BaseHP = (gamedatacontroller.GetBaseHP() - 3);
			}
			Debug.Log("startTex NAme :" + startTexture);
		}
		void Reset() {
			playerHP = initPlayerHP;
			score = beginScore;
		}
		
		public void SetPlayerHP(int hp){
			initPlayerHP = hp;
			playerHP = hp;
		}
		
		public void SetScore(){
			beginScore = score;
		}
		public void GameDataInit(){
			playerHP = initPlayerHP;
			gamedatacontroller = new GameDataController();
		}
		public int GetPlayerHPdata(){
			return gamedatacontroller.GetPlayerHP();
		}
		public int GetInitPlayerHPdata(){
			return gamedatacontroller.GetInitPlayerHP();
		}
		public int GetBaseHPdata(){
			return gamedatacontroller.GetBaseHP();
		}
		public int GetScoredata(){
			return gamedatacontroller.GetScore();
		}
		public int GetMoneydata(){
			return gamedatacontroller.Getmonery();
		}

		public Texture2D GiveStartTexture(){
			Texture2D sendTex = gamedatacontroller.GetStartTexture(startTexture);
			Debug.Log("与えるテクスチャ" + sendTex);
			return sendTex;
		}
		public string GetStartTextureName(){
			string texname = gamedatacontroller.GetStartTexture(startTexture).ToString();
			Debug.Log("スタートテクスチャの名前 ;" + texname);
			return texname;
		}
		public string GetMenuTextureName(){
			Debug.Log("MenuTexName :" + menuTexture);
			return menuTexture.ToString();
		}
		public string GetStageSelectTextureName(){
			Debug.Log("StageSelectTexName :" + stageselectTexture);
			return stageselectTexture.ToString();
		}
		//public string GetTradeTextureName(){
			//return tradeTexture.ToString();
		//}
		public string GetResultTextureName(){
			Debug.Log("ResultTexName :" + resultTexture);
			return resultTexture.ToString();
		}

		public string FormatStartTextureName(){
			Debug.Log(startTexture);
			string texname = GetStartTextureName();
			return texname;
		}
		public string FormatMenuTextureName(){
			return gamedatacontroller.GetMenuTecture(GetMenuTextureName());
		}
		public string FormatStageSelectTextureName(){
			return gamedatacontroller.GetStageSelectTexture(GetStageSelectTextureName());
		}
		//public string FormatTradeTextureName(){
			//return gamedatacontroller.GetTradeTexture(GetTradeTextureName());
		//}
		public string FormatResultTextureName(){
			return gamedatacontroller.GetResultTexture(GetResultTextureName());
		}

	}
}