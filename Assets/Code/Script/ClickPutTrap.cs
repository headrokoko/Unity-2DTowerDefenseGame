using UnityEngine;
using System.Collections;

public class ClickPutTrap : MonoBehaviour {

	public GameObject Trap;
	private Vector3 PutPos;
	private Camera acthibCamera;
	private GameObject touchobj;
	private Vector3 mousepos;
	private Vector3 screenpos;

	public ClickPutTrap(){
		PutPos = Vector3.zero;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit cameraRayHit;
		var CameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		mousepos = Input.mousePosition;
		screenpos = Camera.main.ScreenToWorldPoint(mousepos);
		Trap.transform.position = screenpos;

		if(Input.GetMouseButtonDown(0) && Physics.Raycast(CameraRay,out cameraRayHit,500.0f)){

			PutPos = cameraRayHit.point;
			PutPos.z = 0.0f;
			touchobj = cameraRayHit.collider.gameObject;
			Debug.Log("touch obj tag:" + touchobj.tag);
			Debug.Log(PutPos);
			//PutPos.position.x = Mathf.Round(PutPos.position.x);
			//PutPos.position.y = Mathf.Round(PutPos.position.y);
			//PutPos.position.z = Mathf.Round(PutPos.position.z);
			if(touchobj.tag == "Floor"){
				PutTrap();
			}
		}
	
	}

	void PutTrap(){
		Debug.Log("Put Trap");
		Instantiate(Trap, PutPos ,Trap.transform.rotation);

	}
}
