using UnityEngine;
using System.Collections;

namespace Limone{
	public class SpawnController : MonoBehaviour {

		public float Interval;
		public int WaveNum;
		private int WaveCount = 0;

		public bool StageClear = false;

		private GameObject[] enemy;
		private EnemySpawner[] ESpawners;

		// Use this for initialization
		void Start () {
			ESpawners = GetComponentsInChildren<EnemySpawner>();
			Debug.Log("chidren :" + ESpawners);
			InvokeRepeating("EnemySarch",1.0f,3.0f);
		}
	
		// Update is called once per frame
		void Update () {

			if(Input.GetKeyDown(KeyCode.W)){
				Debug.Log ("ALL Enemy Dead");
				ChildrenComand();
			}

			if(WaveNum == WaveCount){
				StageClear = true;
			}


		}

		void EnemySarch(){
			enemy = GameObject.FindGameObjectsWithTag("Enemy");
			if(enemy.Length == 0){
				Debug.Log ("ALL Enemy Dead");
				ChildrenComand();
			}
		}

		void ChildrenComand(){
			WaveCount++;
			Debug.Log("Now Wave num ;" + WaveCount);
			ESpawners[0].SpawnContact();
			ESpawners[1].SpawnContact();
			ESpawners[2].SpawnContact();
		}
	}
}
