using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main0Con : MonoBehaviour {

	public ButtObj [] Butts;

	void Start () {
		for (int i = 0; i < Butts.Length; i++) {
			int _i = i;
			Butts [i].Del += () => {
				MainCon.Open (_i);
			};
		}
	}
}
