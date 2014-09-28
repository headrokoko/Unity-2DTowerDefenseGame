using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public Rigidbody enemy;
	public int EnemyCount = 10;
	public float SpwanStartTime = 5.0f;
	public float SpwanTime = 1.0f;
	private int SpwanCount = 0;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	if(SpwanCount == EnemyCount){
		Debug.Log ("SpwanLimit");
		CancelInvoke();
		SpwanCount = 0;
	}
	if(Input.GetKeyDown(KeyCode.Z)){
		if(SpwanCount == 0){
			SpwanContact();
		}
		else{
			Debug.Log ("enemy is spwan now");
		}
	}
	}

	public void SpwanContact(){
	InvokeRepeating("Spwan",0.0f,SpwanTime);
	}

	void Spwan(){
	SpwanCount++;
	Rigidbody clone;
	Debug.Log ("spwanenemy");
	clone = Instantiate(enemy,transform.position,transform.rotation)as Rigidbody;
	clone.transform.Translate(0,0.0f,0.0f);
	}

	}