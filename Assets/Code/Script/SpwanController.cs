using UnityEngine;
using System.Collections;

public class SpwanController : MonoBehaviour {

	public float Interval;
	public int WaveNum;
	private int WaveCount = 0;

	private GameObject enemy;
	private EnemySpawner[] ESpwaners;

	// Use this for initialization
	void Start () {
		ESpwaners = GetComponentsInChildren<EnemySpawner>();
		Debug.Log("chidren :" + ESpwaners);
	}
	
	// Update is called once per frame
	void Update () {
		enemy = GameObject.FindGameObjectWithTag("Enemy");

		if(Input.GetKeyDown(KeyCode.W)){
			Debug.Log ("ALL Enemy Dead");
			ChildrenComand();
		}
	}

	void ChildrenComand(){
		WaveCount++;
		ESpwaners[0].SpwanContact();
		ESpwaners[1].SpwanContact();
		ESpwaners[2].SpwanContact();
	}
}
