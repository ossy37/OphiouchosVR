using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour {
	public GameObject prefab; //プレハブ用変数


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		        Vector3 v = this.transform.position;
		        if (Input.GetKey(KeyCode.LeftArrow)){
			            v.z -= 1f;
			        }
		        if (Input.GetKey(KeyCode.RightArrow)){
			             v.z += 1f;
			        }
		        if (Input.GetKey(KeyCode.UpArrow)){
			            v.y += 1f;
			        }
		        if (Input.GetKey(KeyCode.DownArrow)){
			            v.y -= 1f;
			        }
		        this.transform.position = v;
	}

	private void getItem01(){
		StartCoroutine("item01");
	}

	private void getItem02(){
		StartCoroutine ("item02");
	}
		

	IEnumerator item01(){
		transform.localScale += Vector3.up * 10;		// Y方向にサイズを＋１する.
		yield return new WaitForSeconds(10.0f);	// 10秒間、処理を待機.
		transform.localScale -= Vector3.up * 10;		// Y方向にサイズを－１する.
	}

	IEnumerator item02(){
		yield return Instantiate (prefab, transform.position, Quaternion.identity);
	}
		
}
