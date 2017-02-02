using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Title_m : MonoBehaviour {
	public Text blinktext;
	// "public" can create window to put text on Unity 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			Application.LoadLevel ("main");
			// this make player move to any scene with tag
		}

		blinktext.color = new Color (1, 1, 1, Mathf.PingPong (Time.time, 1));
	}
}
