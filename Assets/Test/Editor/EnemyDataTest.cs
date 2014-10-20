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

			this.enemydatacontroller = GetEnemyHealthMock(IEDataController);
			this.enemydatacontroller.EDatacontroller.FormatEnemyHealth().Returns(100);
			this.enemydatacontroller.EDatacontroller.GetEnemyHealth().Returns(100);

			this.enemydatacontroller.EDatacontroller.FormatBulletDamage().Returns(20);
			this.enemydatacontroller.EDatacontroller.GetBulletDamage().Returns(20);

			this.enemydatacontroller.EDatacontroller.FormatSlipDamage().Returns(1);
			this.enemydatacontroller.EDatacontroller.GetSlipDamage().Returns(1);

			this.enemydatacontroller.EDatacontroller.FormatRange().Returns(5.0f);
			this.enemydatacontroller.EDatacontroller.GetRange().Returns(5.0f);

		}
		
		[Test]
		[Category("Enemy Health Test")]
		public void EnemyHealthTest(){
			int number = enemydatacontroller.GetEnemyHealth(100);
			Assert.That(100,Is.EqualTo(number));
		}
		[Test]
		[Category("Health Range Test")]
		public void EnemyHealthRangeTest([Range(-100,100,10)]int x){
			int number = enemydatacontroller.GetEnemyHealth(x);
			Assert.That(x,Is.EqualTo(x));
		}
		[Test]
		[Category("Enemy Health Format Test")]
		public void EnemyHealthFormatTest(){
			int number = IEDataController.FormatEnemyHealth();
			Assert.That(100,Is.EqualTo(number));
		}
		[Test]
		[Category("Get Enemy Health Test")]
		public void GetEnemyHealthTest(){
			int number = IEDataController.GetEnemyHealth();
			Assert.That (100,Is.EqualTo(number));
		}
		
		[Test]
		[Category("Bullet Damage Test")]
		public void BulletDamageTest(){
			int number = enemydatacontroller.GetBulletDamage(20);
			Assert.That(20,Is.EqualTo(number));
		}
		[Test]
		[Category("Bullet Damage Format Test")]
		public void BulletDamageFormatTest(){
			int number = IEDataController.FormatBulletDamage();
			Assert.That(20,Is.EqualTo(number));
		}
		[Test]
		[Category("Get Bullet Damage Test")]
		public void GetBulletDamageTest(){
			int number = IEDataController.GetBulletDamage();
			Assert.That (20,Is.EqualTo(number));
		}
		
		[Test]
		[Category("Slip Damage Test")]
		public void SlipDamageTest(){
			int number = enemydatacontroller.GetSlipDamage(1);
			Assert.That(1,Is.EqualTo(number));
		}
		[Test]
		[Category("Slip Damage Format Test")]
		public void SlipDamageFormatTest(){
			int number = IEDataController.FormatSlipDamage();
			Assert.That(1,Is.EqualTo(number));
		}
		[Test]
		[Category("Get Slip Damage Test")]
		public void GetSlipDamageTest(){
			int number = IEDataController.GetSlipDamage();
			Assert.That (1,Is.EqualTo(number));
		}
		
		[Test]
		[Category("Range Test")]
		public void RangeTest(){
			float number = enemydatacontroller.GetRange(5.0f);
			Assert.That(5.0f,Is.EqualTo(number));
		}
		[Test]
		[Category("Range Format Test")]
		public void RangeFormatTest(){
			float number = IEDataController.FormatRange();
			Assert.That(5.0f,Is.EqualTo(number));
		}
		[Test]
		[Category("Get Range Test")]
		public void GetRangeTest(){
			float number = IEDataController.GetRange();
			Assert.That (5.0f,Is.EqualTo(number));
		}



		private IEnemyDataController EnemyDataMock(){
			return Substitute.For<IEnemyDataController>();
		}

		private EnemyDataController GetEnemyHealthMock(IEnemyDataController enemyhealth){
			var enemyHelth = Substitute.For<EnemyDataController>();
			enemyHelth.SetEnemyDataController(enemyhealth);
			return enemyHelth;
		}
		private EnemyDataController GetBulletDamageMock(IEnemyDataController bulletdamage){
			var Bulletdamage = Substitute.For<EnemyDataController>();
			Bulletdamage.SetEnemyDataController(bulletdamage);
			return Bulletdamage;
		}
		private EnemyDataController GetSlipDamageMock(IEnemyDataController slipdamage){
			var Slipdamage = Substitute.For<EnemyDataController>();
			Slipdamage.SetEnemyDataController(slipdamage);
			return Slipdamage;
		}
		private EnemyDataController GetRange(IEnemyDataController range){
			var Range = Substitute.For<EnemyDataController>();
			Range.SetEnemyDataController(range);
			return Range;
		}



	}
}
