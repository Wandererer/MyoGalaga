﻿using UnityEngine;
using System.Collections;

public class Instantiate2CheckChild : MonoBehaviour {

	int childCount;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		childCount = this.GetComponent<Transform> ().childCount;

		if (childCount == 0)
			Destroy (this.gameObject);
	}
}
