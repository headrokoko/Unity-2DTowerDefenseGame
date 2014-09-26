using UnityEngine;
using System.Collections;

public class GuiBaseHP : MonoBehaviour {
	
	private GUIText BaseHPTex;
	
	private DefenseObjData BaseData;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		BaseData = GameObject.Find("Base").GetComponent<DefenseObjData>();	
		guiText.text = "Base HP :" + BaseData.DefObjHP.ToString();
	}
}
