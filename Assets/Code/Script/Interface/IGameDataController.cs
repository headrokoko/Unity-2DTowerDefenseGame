using System;

namespace Limone{

	public interface IGameDataController
	{
		void GameDataInit();
		int GetPlayerHPdata();
		int GetBaseHPdata();
		int GetScoredata();
		int GetMoneydata();

		int FormatPlayerHP();
		int FormatBaseHP();
		int FormatScore();
		int FormatMoney();
		
		string GetStartTextureName();
		string GetMenuTextureName();
		string GetStageSelectTextureName();
		//string GetTradeTextureName();
		string GetResultTextureName();

		string FormatStartTextureName();
		string FormatMenuTextureName();
		string FormatStageSelectTextureName();
		//string FormatTradeTextureName();
		string FormatResultTextureName();
	}

}
