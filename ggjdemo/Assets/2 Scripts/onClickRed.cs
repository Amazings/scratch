﻿using UnityEngine;
using System.Collections;

public class onClickRed : MonoBehaviour {
	static Shader shader1 = Shader.Find("Diffuse");
	static Shader shader2  = Shader.Find("Particles/Additive");
	//static Shader shader2  = Shader.Find("Particles/Multiply (Double)");
	// Use this for initialization
	void Start () {
		renderer.material.shader = shader2;
		collider.enabled=false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Pressed left click.");
			
			renderer.material.shader = shader2;
			collider.enabled = false;
			
		}
		
		
		
		if (Input.GetMouseButtonDown (1)) {
			Debug.Log ("Pressed right click.");
			renderer.material.shader = shader2;
			collider.enabled = false;
		}
		
		
		
		if (Input.GetMouseButtonDown (2)) {
			Debug.Log ("Pressed middle click.");
			
			renderer.material.shader = shader1;
			
			collider.enabled= true;
		}
	}
}
