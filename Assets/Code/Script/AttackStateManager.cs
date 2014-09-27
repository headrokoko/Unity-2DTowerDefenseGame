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

	public void AttackChange(){
	}

}
