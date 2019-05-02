using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	void Start(){
		//要素が５個のarrayを初期化する
		int[] array = { 10, 20, 30, 40, 50 };

		//配列の各要素に順番に繰り返す


		for (int i = 0; i < 5; i++) {
				

			//コンソールに表示させる
			Debug.Log (array [i]);

		}

		//配列の各要素を逆順に繰り返す
		for (int i = 4; i >= 0; i--) {

			//コンソールに表示させる
			Debug.Log (array [i]);
		}
	}
		

			// Update is called once per frame
	void Update () {
	}		
}