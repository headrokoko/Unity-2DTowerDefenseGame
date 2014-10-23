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
		//Enemy Data Type Test
		[Test]
		[Category("Enemy Health Type Test")]
		public void EnemyHealthTypeTest(){
			Assert.That(enemydatacontroller.GetEnemyHealth(),Is.TypeOf(typeof(int)));
		}
		[Test]
		[Category("Bullet Damage Type Test")]
		public void BulletDamageTypeTest(){
			Assert.That(enemydatacontroller.GetBulletDamage(),Is.TypeOf(typeof(int)));
		}
		[Test]
		[Category("Slip Damage Type Test")]
		public void SlipDamageTypeTest(){
			Assert.That(enemydatacontroller.GetSlipDamage(),Is.TypeOf(typeof(int)));
		}
		[Test]
		[Category("Range Type Test")]
		public void RangeTypeTest(){
			Assert.That(enemydatacontroller.GetRange(),Is.TypeOf(typeof(float)));
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
