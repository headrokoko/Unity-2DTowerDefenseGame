using System;

namespace Limone{

	public interface IGUIPlayerHPController {
		
		void PlayerHPInit();
		int GetGameData();
		string FormatPlayerHP();
	}
}
