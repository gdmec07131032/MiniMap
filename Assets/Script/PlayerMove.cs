﻿using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


    public float speen=4;
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * speen*Time.deltaTime);

	}
}
