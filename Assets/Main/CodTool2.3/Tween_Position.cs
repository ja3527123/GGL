﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween_Position : Tween {
	public Vector3 From;
	public Vector3 To;

	void Start () {
		Del += (f) => {
			transform.localPosition = From + (To - From) * f;
		};
	}
}
