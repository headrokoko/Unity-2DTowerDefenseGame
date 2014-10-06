using UnityEngine;
using System.Collections;

namespace Limone{
	public class GuiPlayerHP : MonoBehaviour {

		private GameData gameData;
		// Use this for initialization
		void Start () {
			gameData = GameObject.Find("GameManager").GetComponent<GameData>();	
		}
		
		// Update is called once per frame
		void Update () {
			guiText.text = "PlayerHP :" + gameData.playerHP.ToString();
		}
	}
}