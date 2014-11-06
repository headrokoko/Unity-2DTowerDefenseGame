using UnityEngine;
using System.Collections;
using Limone;

namespace Limone{
	public class GetParentTestReceiver : MonoBehaviour {

		private int childrennum = 0;
		public GameManagerIntegrationTest inttest;
		void Start(){
			inttest = gameObject.GetComponent<GameManagerIntegrationTest>();
		}

		public int ChildrenCount(){
			childrennum++;
			if(childrennum == 9){
				inttest.ParentCheck = true;
			}
			return childrennum;
		}
	}
}
