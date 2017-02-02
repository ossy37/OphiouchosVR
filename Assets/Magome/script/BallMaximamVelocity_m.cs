using UnityEngine;
using System.Collections;

public class BallMaximamVelocity_m : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		var rb = GetComponent<Rigidbody>();
		var target_velocity = new Vector3(60f, 0f, 0f); // 10m/s の速度が目標
		rb.AddForce(target_velocity*rb.mass*rb.drag/(1f-rb.drag*Time.fixedDeltaTime));
		Debug.Log(rb.velocity.magnitude);
	}
}
