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
		private GameManagerIntegrationTest inttest;

		public GameData(){
		}

		public void OnEnable(){
			//下のthisにはインターフェース(IGameDataController)が入る
			gamedatacontroller.SetGameDataController(this);
			Debug.Log(startTexture);
			GameDataInit();
		}
		
		public void Init(){
			GameDataInit();
		}

		void Update(){
			if(playerHP == 0){
				playerHP = initPlayerHP;
				BaseHP = BaseHP - 3;
			}
			//Debug.Log("startTex NAme :" + startTexture);
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
			inttest = gameObject.GetComponent<GameManagerIntegrationTest>();
			TextureNullCheck();
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

		public void TextureNullCheck(){
			if((startTexture != null)&
			   (menuTexture != null)&
			   (stageselectTexture != null)&
			   (resultTexture != null)){
				inttest.BackGroundTextureCheck = true;
			}
		}

	}
}