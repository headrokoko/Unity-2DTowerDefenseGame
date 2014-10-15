using UnityEngine;
using System;

namespace Limone{
	
	[Serializable]
	public class BulletController{

		public IBulletController bulletController;

		public BulletController(){
		}

		public void SetBulletController(IBulletController bulletcontroller){
			this.bulletController = bulletcontroller;
		}
	}
}
