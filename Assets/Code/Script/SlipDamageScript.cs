﻿using UnityEngine;
using System.Collections;

public class SlipDamageScript : MonoBehaviour {
	
	public float DestroyTime = 5.0f;
	// Use this for initialization
	void Start () {
		Destroy(gameObject,DestroyTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
