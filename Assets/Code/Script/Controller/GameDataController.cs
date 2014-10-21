using UnityEngine;
using System;

namespace Limone{
	
	[Serializable]
	public class GameDataController{

		public Texture2D startTex;
		public Texture2D menuTex;
		public Texture2D stageselectTex;
		public Texture2D resultTex;

		public IGameDataController IgamedataController;
		public GameData GData;

		public GameDataController(){
			GData = new GameData();
		}
		
		void Start() {
		}

		public void SetGameDataController(IGameDataController igamedatacontroller){
			this.IgamedataController = igamedatacontroller;
		}


		public int GetPlayerHP(int playerHP){
			return playerHP;
		}
		public int GetBaseHP(int BaseHP){
			return BaseHP;
		}
		public int GetScore(int score){
			return score;
		}
		public int Getmonery(int money){
			return money;
		}
		
		public Texture2D GetStartTexture(){
			startTex = GData.GiveStartTexture();
			if(startTex == null){
				Debug.LogError("テクスチャが設定されていません");
			}
			return startTex;
		}
		public string GetMenuTecture(string MenuTexure){
			return MenuTexure;
		}
		public string GetStageSelectTexture(string StageSelectTexture){
			return StageSelectTexture;
		}
		public string GetTradeTexture(string TradeTexture){
			return TradeTexture;
		}
		public string GetResultTexture(string ResultTexture){
			return ResultTexture;
		}
	}
}
