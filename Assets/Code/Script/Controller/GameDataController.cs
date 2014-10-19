using UnityEngine;
using System;

namespace Limone{
	
	[Serializable]
	public class GameDataController{

		public IGameDataController gamedataController;

		public GameDataController(){
		}
		
		public void SetGameDataController(IGameDataController gamedatacontroller){
			this.gamedataController = gamedatacontroller;
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
		
		public string GetStartTexture(string StartTexture){
			return StartTexture;
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
