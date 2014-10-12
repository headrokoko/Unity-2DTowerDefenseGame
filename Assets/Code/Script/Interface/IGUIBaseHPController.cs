using System;

namespace Limone{
	
	public interface IGUIBaseHPController
	{
		void BaseHPInit();
		int GetGameData();
		string FormatBaseHP();
	}
}
