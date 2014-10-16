using UnityEngine;
using System;

namespace Limone{
	[Serializable]
	public class LoofGasController{

		public ILoofGasController Loofgascontroller;

		public void SetLoofGasController(ILoofGasController loofgascontroller){
			this.Loofgascontroller = loofgascontroller;
		}

		public void GetLoofGasController(){
		}
	}
}
