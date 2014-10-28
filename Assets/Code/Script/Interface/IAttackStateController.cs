using System;

namespace Limone{
	public interface IAttackStateController{

		void AttackStateManagerInit();
		string GetClickPos();
		string ClickPosOffset();
		string FormatClickPos();
		string FormatClickPosOffset();
	}
}
