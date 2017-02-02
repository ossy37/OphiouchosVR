using UnityEngine;
using System.Collections;

public class Racket_y : MonoBehaviour {

	private float accel = 1000.0f;//加える力の大きさ

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//力を加える
		this.GetComponent<Rigidbody>().AddForce(
			transform.right*Input.GetAxisRaw("Horizontal")*accel,
			ForceMode.Impulse);
		this.GetComponent<Rigidbody>().AddForce(
			transform.up*Input.GetAxisRaw("Vertical")*accel,
			ForceMode.Impulse);
	}
}