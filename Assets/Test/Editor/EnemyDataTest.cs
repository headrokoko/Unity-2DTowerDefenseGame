using NUnit.Framework;
using System;
using NSubstitute;

namespace Limone.Test{
	
	[TestFixture]
	[Category("EnemyData Test")]

	public class EnemyDataTest{

		public IEnemyDataController IEDataController;
		public EnemyDataController enemydatacontroller;

		[SetUp] public void Init(){
			this.IEDataController = EnemyDataMock();
			this.enemydatacontroller = GetEnemyDataMock(IEDataController);

		}



		private IEnemyDataController EnemyDataMock(){
			return Substitute.For<IEnemyDataController>();
		}

		private EnemyDataController GetEnemyDataMock(IEnemyDataController ienemydata){
			var enemydata = Substitute.For<EnemyDataController>();
			enemydata.SetEnemyDataController(ienemydata);
			return enemydata;
		}
	}
}
