using System;

namespace Limone{
	public interface IStateManagerController {

		void StateManagerInit();
		string FormatStateManager();
		string GetStateName();
	}
}
