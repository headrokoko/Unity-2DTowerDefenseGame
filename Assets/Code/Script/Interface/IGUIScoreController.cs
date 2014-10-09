using System;

namespace Limone{

	public interface IGUIScoreController
	{
		void GenericInit();
		int GetGameData();
		string FormatScore();
	}
}