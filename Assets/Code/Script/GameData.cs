using UnityEngine;
using System.Collections.Generic;

namespace Limone{
	public class GameData : MonoBehaviour,IGameDataController {
		
		// athenaeum test
		public Texture2D startTexture;
		public Texture2D menuTexture;
		public Texture2D stageselectTexture;
		public Texture2D tradeTexture;
		public Texture2D resultTexture;
		
		public List<GameObject> cameras;
		
		private int initPlayerHP = 10;
		private int beginScore;

		public int playerHP;
		[HideInInspector]
		public int BaseHP;
		public int score;
		public int Money;

		public GameDataController gamedatacontroller;

		public void OnEnable(){
			//下のthisにはインターフェース(IGameDataController)が入る
			gamedatacontroller.SetPlayerHPDataController(this);
			gamedatacontroller.SetBaseHPDataController(this);
			gamedatacontroller.SetScoreDataController(this);
			gamedatacontroller.SetMoneyDataController(this);
		}
		
		void Start() {
			GameDataInit();
		}

		void Update(){
			if(playerHP == 0){
				playerHP = gamedatacontroller.GetPlayerHP(10);
				BaseHP = gamedatacontroller.GetBaseHP(BaseHP - 3);
			}
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
		}
		public int GetPlayerHPdata(){
			return playerHP;
		}
		public int GetBaseHPdata(){
			return BaseHP;
		}
		public int GetScoredata(){
			return score;
		}
		public int GetMoneydata(){
			return Money;
		}
		public int FormatPlayerHP(){
			return gamedatacontroller.GetPlayerHP(GetPlayerHPdata());
		}
		public int FormatBaseHP(){
			return gamedatacontroller.GetBaseHP(GetBaseHPdata());
		}
		public int FormatScore(){
			return gamedatacontroller.GetScore(GetScoredata());
		}
		public int FormatMoney(){
			return gamedatacontroller.Getmonery(GetMoneydata());
		}
	}
}