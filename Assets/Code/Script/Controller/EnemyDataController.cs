using UnityEngine;
using System;

namespace Limone{

	[Serializable]
	public class EnemyDataController{

		public IEnemyDataController EDatacontroller;
		public EnemyController enemydata;

		public EnemyDataController(){
			enemydata = new EnemyController();
		}
		
		public void SetEnemyDataController(IEnemyDataController eDatacontroller){
			this.EDatacontroller = eDatacontroller;
		}

		public int GetEnemyHealth(){
			return enemydata.health;
		}

		public int GetBulletDamage(){
			return enemydata.BulletDamage;
		}

		public int GetSlipDamage(){
			return enemydata.SlipDamage;
		}

		public float GetRange(){
			return enemydata.Range;
		}
	}

}
