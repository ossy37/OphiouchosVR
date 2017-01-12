﻿using UnityEngine;
using System.Collections;

public class gyro : MonoBehaviour {
	#if UNITY_EDITOR
	private Vector3 rot;
	#endif

	// Use this for initialization
	void Start () {
		for(int i=0; i<100; ++i){
			GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
			go.transform.position = Random.onUnitSphere*10f;
			go.transform.rotation = Random.rotation;
		}
		#if UNITY_EDITOR
		rot = transform.rotation.eulerAngles;
		#else
		Input.gyro.enabled = true;
		#endif
	}

	// Update is called once per frame
	void Update () {
		#if UNITY_EDITOR
		float spd = Time.deltaTime*100.0f;
		if(Input.GetKey(KeyCode.LeftArrow)){
			rot.y -= spd;
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			rot.y += spd;
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			rot.x -= spd;
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			rot.x += spd;
		}
		transform.rotation = Quaternion.Euler(rot);
		#else
		transform.rotation = Quaternion.AngleAxis(90.0f,Vector3.right)*Input.gyro.attitude*Quaternion.AngleAxis(180.0f,Vector3.forward);
		#endif

	}
}
