using UnityEngine;
using System;

namespace Limone{

	[Serializable]
	public class EnemyDataController{

		public IEnemyDataController EDatacontroller;
		public EnemyController Edata;

		public EnemyDataController(){
			Edata = new EnemyController();
		}
		
		public void SetEnemyDataController(IEnemyDataController eDatacontroller){
			this.EDatacontroller = eDatacontroller;
		}

		public int GetEnemyHealth(){
			return Edata.health;
		}

		public int GetBulletDamage(){
			return Edata.BulletDamage;
		}

		public int GetSlipDamage(){
			return Edata.SlipDamage;
		}

		public float GetRange(){
			return Edata.Range;
		}
	}

}
