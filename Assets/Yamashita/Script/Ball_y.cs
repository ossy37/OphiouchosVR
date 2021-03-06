using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Ball_y : MonoBehaviour {

	private float speed = 20.0f;    //これを追加

	// Use this for initialization
	void Start () {
		//以下を追加
		this.GetComponent<Rigidbody>().AddForce(
			(transform.forward + transform.right + transform.up) * speed,
			ForceMode.VelocityChange);

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		//衝突判定
		if (collision.gameObject.tag == "BottomWall") {
			//相手のタグがBallならば、自分を消す
			Destroy (this.gameObject);

		}
	}

}