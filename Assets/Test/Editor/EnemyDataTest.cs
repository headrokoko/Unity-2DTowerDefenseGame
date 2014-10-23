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
		
		[Test]
		[Category("Enemy Health Type Test")]
		public void EnemyHealthTypeTest(){
			Assert.That(enemydatacontroller.GetEnemyHealth(),Is.TypeOf(typeof(int)));
		}
		[Test]
		[Category("Enemy Health Get Value Test")]
		public void EnemyHealthGetValueTest(){
			Assert.That(100,Is.EqualTo(enemydatacontroller.GetEnemyHealth()));
		}
		
		[Test]
		[Category("Bullet Damage Type Test")]
		public void BulletDamageTypeTest(){
			Assert.That(enemydatacontroller.GetBulletDamage(),Is.TypeOf(typeof(int)));
		}
		[Test]
		[Category("Get Bullet Damage Test")]
		public void GetBulletDamageTest(){
			Assert.That (20,Is.EqualTo(enemydatacontroller.GetBulletDamage()));
		}
		
		[Test]
		[Category("Slip Damage Type Test")]
		public void SlipDamageTypeTest(){
			Assert.That(enemydatacontroller.GetSlipDamage(),Is.TypeOf(typeof(int)));
		}
		[Test]
		[Category("Get Slip Damage Test")]
		public void GetSlipDamageTest(){
			Assert.That (1,Is.EqualTo(enemydatacontroller.GetSlipDamage()));
		}
		
		[Test]
		[Category("Range Type Test")]
		public void RangeTypeTest(){
			Assert.That(enemydatacontroller.GetRange(),Is.TypeOf(typeof(float)));
		}
		[Test]
		[Category("Get Range Test")]
		public void GetRangeTest(){
			Assert.That (5.0f,Is.EqualTo(enemydatacontroller.GetRange()));
		}

		private IEnemyDataController EnemyDataMock(){
			return Substitute.For<IEnemyDataController>();
		}

		private EnemyDataController GetEnemyDataMock(IEnemyDataController Ienemydata){
			var ienemydata = Substitute.For<EnemyDataController>();
			ienemydata.SetEnemyDataController(Ienemydata);
			return ienemydata;
		}
	}
}
