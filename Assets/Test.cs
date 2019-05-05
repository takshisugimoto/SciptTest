using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {


	void Start () {

		//５個の配列を初期化する
		int[] array = { 10, 20, 30, 40, 50 };
		//配列の各要素を順番に繰り返す
		for (int i = 0; i < array.Length; i++) {
			//コンソールに表示する
			Debug.Log (array [i]);
		}

		//5個の配列を逆順に繰り返す
		for (int i = array.Length - 1; i >= 0; i--) {
			//コンソールに表示させる
			Debug.Log (array [i]);
		}
	}


	void Update () {
	}
}