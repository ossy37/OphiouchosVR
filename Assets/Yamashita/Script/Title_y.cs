using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Title_y : MonoBehaviour {

	public Text blinktext;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKeyDown) {
			Application.LoadLevel ("main");
		}

		blinktext.color = new Color (1, 1, 1, Mathf.PingPong (Time.time, 1));

	}
}
