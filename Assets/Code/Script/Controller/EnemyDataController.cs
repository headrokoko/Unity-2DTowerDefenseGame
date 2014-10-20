using UnityEngine;
using System;

namespace Limone{

	[Serializable]
	public class EnemyDataController{

		public IEnemyDataController EDatacontroller;

		public EnemyDataController(){
		}
		
		public void SetEnemyDataController(IEnemyDataController eDatacontroller){
			this.EDatacontroller = eDatacontroller;
		}

		public int GetEnemyHealth(int enemyhealth){
			return enemyhealth;
		}

		public int GetBulletDamage(int bulletdamage){
			return bulletdamage;
		}

		public int GetSlipDamage(int slipdamage){
			return slipdamage;
		}

		public float GetRange(float range){
			return range;
		}
	}

}
