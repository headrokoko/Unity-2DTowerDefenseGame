using UnityEngine;
using System.Collections;

public class EnemyController : AdvancedFSM {
	
	public GameObject Bullet;
	public int health = 10;
	public float Range = 5f;
	
	//NPC FSMの初期化
	protected override void Initialize()
	{
		health = 100;
		
		elapsedTime = 0.0f;
		shootRate = 2.0f;
		
		GameObject objPlayer = GameObject.FindGameObjectWithTag("Player");
		GameObject objTarget = GameObject.FindGameObjectWithTag("Defense");
		playerTransform = objPlayer.transform;
		targetTransform = objTarget.transform;
		
		if (!playerTransform)
			print("プレーヤーが存在しません。タグ 'Player'　を追加してください。");
		
		//　戦車の砲台を取得
		//turret = gameObject.transform.GetChild(0).transform;
		//bulletSpawnPoint = turret.GetChild(0).transform;
		
		// FSMを構築
		ConstructFSM();
	}
	
	protected override void FSMUpdate()
	{
		//　ヘルスチェック
		elapsedTime += Time.deltaTime;
	}
	
	protected override void FSMFixedUpdate()
	{
		CurrentState.Reason(playerTransform, transform);
		CurrentState.Act(playerTransform, transform, targetTransform);
	}
	
	public void SetTransition(Transition t) 
	{ 
		PerformTransition(t); 
	}
	
	private void ConstructFSM()
	{
		//ポイントのリスト
		//pointList = GameObject.FindGameObjectsWithTag("WandarPoint");
		
		//Transform[] waypoints = new Transform[pointList.Length];
		//int i = 0;
		//foreach(GameObject obj in pointList)
		//{
			//waypoints[i] = obj.transform;
			//i++;
		//}
		
		MarchState March = new MarchState(targetTransform);
		March.AddTransition(Transition.SawPlayer, FSMStateID.Attacking);
		March.AddTransition(Transition.NoHealth, FSMStateID.Dead);
		
		PlayerAttackState PlayerAttack = new PlayerAttackState(playerTransform);
		PlayerAttack.AddTransition(Transition.LostPlayer, FSMStateID.March);
		PlayerAttack.AddTransition(Transition.NoHealth, FSMStateID.Dead);
		
		EnemyDead EDead = new EnemyDead();
		EDead.AddTransition(Transition.NoHealth, FSMStateID.Dead);
		
		AddFSMState(March);
		AddFSMState(PlayerAttack);
		AddFSMState(EDead);
	}	
	//　弾丸の衝突判定
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Dead")
		{
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter(Collider collider){
		//hpを減少させます
		if(collider.gameObject.tag == "Bullet"){
			health -= 100;
			if (health <= 0)
			{
				Debug.Log("Switch to Dead State");
				SetTransition(Transition.NoHealth);
				Explode();
			}
		}
		
	}
	
	protected void Explode()
	{
		float rndX = Random.Range(10.0f, 30.0f);
		float rndZ = Random.Range(10.0f, 30.0f);
		for (int i = 0; i < 3; i++)
		{
			rigidbody.AddExplosionForce(10000.0f, transform.position - new Vector3(rndX, 10.0f, rndZ), 40.0f, 10.0f);
			rigidbody.velocity = transform.TransformDirection(new Vector3(rndX, 20.0f, rndZ));
		}
		
		Destroy(gameObject, 1.5f);
	}
	
	public void ShootBullet()
	{
		if (elapsedTime >= shootRate)
		{
			Instantiate(Bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
			elapsedTime = 0.0f;
		}
	}
	void OnDrawGizmos(){
		Vector3 frontend = transform.position + (transform.forward * 10.0f) ;
		Debug.DrawLine(transform.position,frontend,Color.red);
	}
}