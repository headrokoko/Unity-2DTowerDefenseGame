using System;

namespace Limone{
	public interface IEnemyDataController{

		int GetEnemyHealth();
		int GetBulletDamage();
		int GetSlipDamage();
		float GetRange();
		int FormatEnemyHealth();	
		int FormatBulletDamage();
		int FormatSlipDamage();
		float FormatRange();
	}
}
