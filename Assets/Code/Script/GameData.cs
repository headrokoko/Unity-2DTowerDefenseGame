using UnityEngine;
using System.Collections.Generic;

public class GameData : MonoBehaviour {
	
	// athenaeum test
	public Texture2D beginTexture;
	public Texture2D menuTexture;
	public Texture2D stageselectTexture;
	public Texture2D tradeTexture;
	public Texture2D resultTexture;
	
	public List<GameObject> cameras;
	
	private int initPlayerHP = 10;
	private int beginScore;
	
	[HideInInspector]
	public int playerHP;
	[HideInInspector]
	public int score;
	
	void Start() {
		playerHP = initPlayerHP;
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
