using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main1Con : MonoBehaviour {

	public ButtObj NextButt;
	public ButtObj OutButt;
	public DrawMask drawMask;

	public ObjArray Texts;
	public ObjArray Names;

	void Start () {
		NextButt.Del += () => {
			int r = ((MainCon.NowN + 2) % (Names.AllObj.Length + 1)) - 1;
			MainCon.Reset (r);
		};
		OutButt.Del += () => {
			MainCon.Reset (-1);
		};
		drawMask.onStartDraw += (pos) => {
			StartCoroutine (OpenNextButt ());
		};
	}

	public void Open () {
		if (MainCon.NowN >= 0 && MainCon.NowN < Names.AllObj.Length) {
			//改變刮漆下的字
			if (MainCon.NowN < 3) {
				Texts.OnOnlyObjs (0);
			} else {
				Texts.OnOnlyObjs (1);
			}
			Names.OnOnlyObjs (MainCon.NowN);
			print (MainCon.NowN);
		} else {
			print ("編號錯誤退回上一頁");
			 MainCon.Reset (-1);
		}
	}

	public IEnumerator OpenNextButt () {
		yield return new WaitForSeconds (3);
		NextButt.gameObject.SetActive (true);
	}
}