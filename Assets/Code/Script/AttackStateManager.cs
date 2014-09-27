using UnityEngine;
using Assets.Code.States;

public class AttackStateManager : MonoBehaviour {


	public static AttackStateManager attackManager;
	public Rigidbody Bullet;
	public GameObject Floor;
	public GameObject Wall;
	public GameObject Loof;
	private GameObject Weapon;

	private GunShotState gunSt;
	private FloorTrapState floorSt;
	private WallTrapState wallSt;
	private LoofTrapState loofSt;
	
	
	void Awake(){
		if(attackManager == null){
			attackManager = this;
			DontDestroyOnLoad(gameObject);
		}
		else{
			DestroyImmediate(gameObject);	
		}
	}
	// Use this for initialization
	void Start () { 

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGui(){
		if(GUI.Button(new Rect(250,450,50,50),"Gun")){
			Debug.Log("Gun shot mode");
		}

		else if(GUI.Button(new Rect(250,150,50,50),"Floor")){
			Debug.Log("Floor trap mode");
		}

		else if(GUI.Button(new Rect(250,250,50,50),"Wall")){
			Debug.Log("Wall trap mode");
		}

		else if(GUI.Button(new Rect(250,350,50,50),"Loof")){
			Debug.Log("Loof trap mode");
		}
	}
}
