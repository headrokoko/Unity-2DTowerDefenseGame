﻿using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	public float betweenPlayer = 15.0f;
	public float height = 5.0f;

	private Transform playerpos;

	// Use this for initialization
	void Start () {
		playerpos = GameObject.Find("Player").transform;	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = playerpos.position + new Vector3(0.0f,height,-betweenPlayer);
		transform.LookAt(playerpos);
	}
}