using UnityEngine;
using System.Collections;

public class Block_k : MonoBehaviour {

	public GameObject item;		// プレハブ用変数.

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		//衝突判定
		if (collision.gameObject.tag == "Ball") {
			//相手のタグがBallならば、自分を消す
			Destroy(this.gameObject);
			Instantiate(item , transform.position , Quaternion.identity);	
		}
	}
}
