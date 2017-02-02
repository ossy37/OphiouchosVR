using UnityEngine;
using System.Collections;

public class Racket_m : MonoBehaviour {

	private float accel = 500.0f;//加える力の大きさ

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//力を加える
		this.GetComponent<Rigidbody>().AddForce(
			transform.right * Input.GetAxisRaw("Horizontal") * accel,
			ForceMode.Impulse);
		this.GetComponent<Rigidbody>().AddForce(
			transform.up * Input.GetAxisRaw("Vertical") * accel,
			ForceMode.Impulse);
		//this.transform.localScale = new Vecter3 ( , , );
	}
}