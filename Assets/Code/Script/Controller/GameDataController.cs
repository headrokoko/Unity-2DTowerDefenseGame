using UnityEngine;
using System;

namespace Limone{
	
	[Serializable]
	public class GameDataController{

		public IGameDataController gamedataController;

		public GameDataController(){
		}

		public void SetPlayerHPDataController(IGameDataController gamedatacontroller){
			this.gamedataController = gamedatacontroller;
		}
		public void SetBaseHPDataController(IGameDataController gamedatacontroller){
			this.gamedataController = gamedatacontroller;
		}
		public void SetScoreDataController(IGameDataController gamedatacontroller){
			this.gamedataController = gamedatacontroller;
		}
		public void SetMoneyDataController(IGameDataController gamedatacontroller){
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
	}
}
