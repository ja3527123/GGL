using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCon : ObjArray {
	static public MainCon _;

	static public int NowN = -1;

	[Serializable]
	public struct _UI {
		public Main0Con main0;
		public Main1Con main1;
	}
	public _UI UI;

	void Awake () {
		_ = this;
	}

	void Start () {
		Open ();
	}

	static public void Open (int i) {
		NowN = i;
		Open ();
	}

	static public void Open () {
		if (NowN < 0) {
			_.OnOnlyObjs (0);
		} else {
			_.OnOnlyObjs (1);
		}
	}
	static public void Reset (int i) {
		MainCon.NowN  = i;
		SceneManager.LoadScene ("Main");
	}
}