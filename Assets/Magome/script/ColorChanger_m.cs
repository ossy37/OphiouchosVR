using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorChanger_m : MonoBehaviour {
	public float rcolor = 0;
	//public Color changecolor;

    // Use this for initialization
	void Start () {
		//GetComponent<Renderer>().material.color = Color.red;

		//Renderer rend = GetComponent<Renderer>();
		//rend.material.shader = Shader.Find ("Specular");
		//rend.material.SetColor("_SpecColor", Color.red)

		//this.renderer.material.color = new Color (1f, 2f, 3f, 4f);
	}

	// Update is called once per frame
	void Update () {
		rcolor = Mathf.Sin(Time.time);
		this.GetComponent<Renderer>().material.color = new Color (rcolor, 2f, 3f, 4f);
	}
}