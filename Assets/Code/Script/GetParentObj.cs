using UnityEngine;
using System.Collections;
using Limone;

namespace Limone{
	public class GetParentObj : MonoBehaviour {

		public GameObject parentobj;
		public GetParentTestReceiver receiver;
		// Use this for initialization
		void Start () {
			receiver = GameObject.Find("GameManager").GetComponent<GetParentTestReceiver>();
			parentobj = gameObject.transform.parent.gameObject;
			if(parentobj != null){
				receiver.ChildrenCount();
			}
		}	
	}
}
