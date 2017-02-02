using UnityEngine;
using System.Collections;

public class Item2_k : MonoBehaviour {

	private float speed = 5.0f;

	// Use this for initialization
	void Start () {

		this.GetComponent<Rigidbody>().AddForce(
			(transform.right) * speed,
			ForceMode.VelocityChange);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {		// 衝突した相手のタグ名がplayerなら
			other.transform.root.SendMessage("getItem02");
			Destroy (gameObject);					// 自分を削除.
		}
	}
}
