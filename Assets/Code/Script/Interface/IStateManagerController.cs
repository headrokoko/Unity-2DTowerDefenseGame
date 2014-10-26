using System;

namespace Limone{
	public interface IStateManagerController {

		void StateManagerInit();
		string SwichState(IState istate);
	}
}
