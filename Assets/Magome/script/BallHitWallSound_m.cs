﻿using UnityEngine;
using System.Collections;

public class BallHitWallSound_m : MonoBehaviour {
	public AudioClip audioClip;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = audioClip;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "wall") {
			audioSource.PlayOneShot (audioClip);
		}
	}
}
