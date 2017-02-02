using UnityEngine;
using System.Collections;

public class Ball_k : MonoBehaviour {

	private float speed = 10.0f;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().AddForce(
			(transform.forward + transform.right + transform.up) * speed ,
			ForceMode.VelocityChange);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
