using UnityEngine;
using System.Collections;

public class Powerup : MonoBehaviour {
	
	void OnTriggerEnter(Collider other)
	{
		var scale = other.transform.localScale;
		other.transform.localScale = scale * 2;
	}
}
