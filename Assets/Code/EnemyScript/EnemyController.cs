using UnityEngine;
using System.Collections;

public class EnemyController : AdvancedFSM {

	public int health = 10;
	public float Range = 5f;
	private GameData gamedata;
	
	//NPC FSMの初期化

	public EnemyController(){
	}

	protected override void Initialize()
	{
		health = 100;
		
		elapsedTime = 0.0f;
		shootRate = 2.0f;
		gamedata = GameObject.Find("GameManager").GetComponent<GameData>();
		
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
		Debug.Log("Actib state :" + CurrentState);
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
		March.AddTransition(Transition.SawPlayer, FSMStateID.PlayerAttack);
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
			Explode();
		}
	}

	void OnTriggerEnter(Collider collider){
		//hpを減少させます
		if(collider.gameObject.tag == "Bullet"){
			health -= 50;
			if (health <= 0)
			{
				Debug.Log("Switch to Dead State");
				SetTransition(Transition.NoHealth);
				Explode();
			}
		}
		if (collider.gameObject.tag == "Dead")
		{
			Debug.Log("Switch to Dead State");
			SetTransition(Transition.NoHealth);
			Explode();
		}
		
	}
	
	protected void Explode()
	{
		float rndX = Random.Range(10.0f, 30.0f);
		float rndy = Random.Range(10.0f, 30.0f);
		float rndZ = Random.Range(10.0f, 30.0f);
		for (int i = 0; i < 3; i++)
		{
			rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
			rigidbody.useGravity = true;
			transform.rigidbody.AddForce((Vector3.back * 300.0f) + (Vector3.up * 900.0f));
			//rigidbody.AddExplosionForce(10000.0f, transform.position - new Vector3(rndX, 10.0f, rndZ), 40.0f, 10.0f);
			//rigidbody.velocity = transform.TransformDirection(new Vector3(rndX, rndy, ndZ));
		}
		gamedata.score += 1;
		gamedata.Money += 100;
		Destroy(gameObject, 1.5f);
	}

	void OnDrawGizmos(){
		Vector3 frontend = transform.position + (transform.forward * 10.0f) ;
		Debug.DrawLine(transform.position,frontend,Color.red);
	}
}