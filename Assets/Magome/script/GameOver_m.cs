using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver_m : MonoBehaviour {
	public Text gameover;

	// Use this for initialization
	void Start () {
		gameover.enabled = false;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision collision) {
		//衝突判定
		if (collision.gameObject.tag == "Ball") {
			//相手のタグがBallならば、Gameoverと出力
			Debug.Log("GAMEOVER");
			gameover.enabled = true;
		}
	}
}