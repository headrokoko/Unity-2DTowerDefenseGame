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
	}

}
