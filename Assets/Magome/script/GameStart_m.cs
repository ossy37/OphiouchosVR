using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameStart_m : MonoBehaviour {
	float timer;
	public Text gamestart;

	// Use this for initialization
	void Start () {
		timer = 0;
		gamestart.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer > 1) {
			gamestart.enabled = false;
			timer = 0;
		}
	}
}
