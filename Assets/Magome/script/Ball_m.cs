using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ball_m : MonoBehaviour {

	private float speed = 8.0f;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().AddForce(
			(3*transform.forward/2 + transform.right/2 + transform.up/3) * speed,
			ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnCollisionEnter(Collision collision) {
		//衝突判定
		if (collision.gameObject.name == "BottomWall") {
			//相手のnamaeがBottomWallならば、自分を消す
			Destroy(this.gameObject);
		}
	}
}
