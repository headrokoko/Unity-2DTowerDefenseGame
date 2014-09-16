using UnityEngine;
using Assets.Code.EnemyStates;
using Assets.Code.Interfaces;
using System.Collections;

namespace Assets.Code.EnemyStates{
	public class MarchState : MonoBehaviour,EnemyState {
		public Transform EnemyPos;
		public float Range = 5f;
		public float Speed = 0.01f;
		public Transform enemyTransform;
		bool targetDiscovery = false;

		private EnemyStateManager Emanager;
		private Transform targetpos;
		public MarchState(EnemyStateManager Estatemanager){
			Emanager = Estatemanager;


		}
		//March State プレイヤーを発見するまでは目標に向かって行進
		public void EStateUpdata(){
			//RaycastHit hit;
			Debug.Log("March");
			//目標の座標を探す
			if(targetDiscovery == false){
				Targetsarch();
				Debug.Log(targetpos.position);
			}
			//目標まで行進する処理
			//Debug.Log (enemyTransform.position);
			//transform.LookAt(targetpos.position);
			enemyTransform.transform.LookAt(targetpos,Vector3.up);
			enemyTransform.Translate(Vector3.forward * Time.deltaTime * Speed);
		}

		//目標の座標を探す処理
		public void Targetsarch(){
			targetpos = Emanager.Target.transform;
			targetDiscovery = true;
		}

		void OnDrawGizmos(){
			Vector3 frontend = transform.position + (transform.forward * Range) ;
			Vector3 loolup = transform.position + ((transform.forward *5) + (transform.up * 5));
			Debug.DrawLine(transform.position,frontend,Color.red);
			Debug.DrawLine(transform.position,loolup,Color.red);
		}
	}
}
