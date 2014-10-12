using System;

namespace Limone{
	
	public interface IGUIMoneyController
	{
		void MoneyInit();
		int GetGameData();
		string FormatMoney();
	}
}
