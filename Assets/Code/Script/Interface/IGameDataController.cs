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

	}

}
