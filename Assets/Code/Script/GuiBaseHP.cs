using UnityEngine;
using System.Collections;

public class GuiBaseHP : MonoBehaviour {
	
	private GUIText BaseHPTex;
	
	private DefenseObjData BaseData;
	// Use this for initialization
	void Start () {
		BaseData = GameObject.Find("Base").GetComponent<DefenseObjData>();	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Base HP :" + BaseData.DefObjHP.ToString();
		Debug.Log("text" + BaseData.DefObjHP);
	}
}
