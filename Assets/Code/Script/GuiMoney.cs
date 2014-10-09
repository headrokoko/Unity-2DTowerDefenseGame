using UnityEngine;
using System.Collections;

public class GuiMoney : MonoBehaviour {

	private GUIText MoneyText;
	
	private GameData gameData;
	// Use this for initialization
	void Start () {
		gameData = GameObject.Find("GameManager").GetComponent<GameData>();	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Money :" + gameData.Money.ToString();
	}
}
