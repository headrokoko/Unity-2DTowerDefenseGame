using UnityEngine;
using System.Collections;

namespace Limone{
	public class DamageObjScr : MonoBehaviour {
		
		public float DestroyTime = 0.5f;
		// Use this for initialization
		void Start () {
			Destroy(gameObject,DestroyTime);
		}
	}
}
