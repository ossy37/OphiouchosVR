using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class GameManager_y : MonoBehaviour {

	float timer;

	public Text GameStart;

	// Use this for initialization
	void Start () {
	
		timer = 0;
		GameStart.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
		timer += Time.deltaTime;

		if (timer >= 1) {
			GameStart.enabled = false;
			timer = 0;
		}
	}
}