using System;

namespace Limone{

	public interface IGUIScoreController
	{
		void ScoreInit();
		int GetGameData();
		string FormatScore();
	}
}