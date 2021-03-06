﻿using UnityEngine;
using System.Collections;

public class Instantiate90Move : MonoBehaviour {
	float x, y, z;
	float moveSpeedZ = 0.1f, moveSpeedX = 0.2f, moveSpeedY = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		x = this.GetComponent<Transform>().position.x;
		y = this.GetComponent<Transform>().position.y;
		z = this.GetComponent<Transform>().position.z;

		if (z > 17)
		{
			this.GetComponent<Transform>().position = new Vector3(x, y, z -= moveSpeedZ);
		}
		else
		{
			this.GetComponent<Transform>().position = new Vector3(x -= moveSpeedX, y += moveSpeedY, z -= moveSpeedZ);
			GetComponent<Transform>().Rotate((new Vector3(-0.1f, 0.1f, 0)));
		}


		if (z < -10)
			Destroy(this.gameObject);
	}
}
