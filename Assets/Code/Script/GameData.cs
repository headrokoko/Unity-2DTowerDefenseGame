using UnityEngine;
using System.Collections.Generic;

namespace Limone{
	public class GameData : MonoBehaviour {
		
		// athenaeum test
		public Texture2D startTexture;
		public Texture2D menuTexture;
		public Texture2D stageselectTexture;
		public Texture2D tradeTexture;
		public Texture2D resultTexture;
		
		public List<GameObject> cameras;
		
		private int initPlayerHP = 10;
		private int beginScore;

		public int playerHP;
		[HideInInspector]
		public int BaseHP;
		public int score;
		public int Money;


		
		void Start() {
			playerHP = initPlayerHP;
		}

		void Update(){
			if(playerHP == 0){
				playerHP = 10;
				BaseHP -= 3;
			}
		}
		void Reset() {
			playerHP = initPlayerHP;
			score = beginScore;
		}
		
		public void SetPlayerHP(int hp) 
		{
			initPlayerHP = hp;
			playerHP = hp;
		}
		
		public void SetScore()
		{
			beginScore = score;
		}
	}
}