using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour {

	void Start () {
		SetGazedAt(false);
	}

	void Update () {

	}

	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
	}

	public void OnGazeEnter() {
		Debug.Log ("OnGazeEnter");
		SetGazedAt(true);
	}

	public void OnGazeExit() {
		Debug.Log ("OnGazeExit");
		SetGazedAt(false);
	}
}
