using UnityEngine;
using System.Collections;

namespace Limone{
	public class EnemySpawner : MonoBehaviour {

		public Rigidbody enemy;
		public int EnemyCount = 10;
		public float SpawnStartTime = 5.0f;
		public float SpawnTime = 1.0f;
		private int SpawnCount = 0;
		// Use this for initialization
		void Start () {
		}

		// Update is called once per frame
		void Update () {
		if(SpawnCount == EnemyCount){
			Debug.Log ("SpawnLimit");
			CancelInvoke();
			SpawnCount = 0;
		}
			if(Input.GetKeyDown(KeyCode.Z)){
				if(SpawnCount == 0){
					SpawnContact();
				}
				else{
				Debug.Log ("enemy is spwan now");
				}
			}
		}

		public void SpawnContact(){
		InvokeRepeating("Spawn",0.0f,SpawnTime);
		}

		void Spawn(){
		SpawnCount++;
		Rigidbody clone;
		Debug.Log ("spwanenemy");
		clone = Instantiate(enemy,transform.position,transform.rotation)as Rigidbody;
		clone.transform.Translate(0,0.0f,0.0f);
		}
	}
}