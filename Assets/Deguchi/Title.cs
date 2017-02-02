using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Title : MonoBehaviour {

        public Text blinktext;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	        //文字点滅
	        blinktext.color = new Color(1, 1, 1, Mathf.PingPong(Time.time, 1));
	}
}
