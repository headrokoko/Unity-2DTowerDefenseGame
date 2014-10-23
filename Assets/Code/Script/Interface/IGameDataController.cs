using System;

namespace Limone{

	public interface IGameDataController
	{
		void GameDataInit();
		int GetPlayerHPdata();
		int GetInitPlayerHPdata();
		int GetBaseHPdata();
		int GetScoredata();
		int GetMoneydata();
		
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
