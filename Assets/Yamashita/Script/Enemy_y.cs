using UnityEngine;
using System.Collections;

public class Enemy_y : MonoBehaviour {
	
	private float speed = 20.0f; 

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().AddForce(
			(transform.right) * speed,
			ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		//衝突判定
		if (collision.gameObject.tag == "Ball") {
			//相手のタグがBallならば、自分を消す
			Destroy (this.gameObject);

		}
	}
}
