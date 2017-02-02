using UnityEngine;
using System.Collections;

public class Block_m : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		//衝突判定
		if (collision.gameObject.tag == "ball") {
			//相手のタグがBallならば、自分を消す
			Destroy(this.gameObject);
		}
	}
}