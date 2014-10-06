using UnityEngine;
using System.Collections;
using Limone;

namespace Limone{
	public class SpwanController : MonoBehaviour {

		public float Interval;
		public int WaveNum;
		private int WaveCount = 0;

		public bool StageClear = false;

		private GameObject[] enemy;
		private EnemySpawner[] ESpwaners;

		// Use this for initialization
		void Start () {
			ESpwaners = GetComponentsInChildren<EnemySpawner>();
			Debug.Log("chidren :" + ESpwaners);
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
			ESpwaners[0].SpwanContact();
			ESpwaners[1].SpwanContact();
			ESpwaners[2].SpwanContact();
		}
	}
}
