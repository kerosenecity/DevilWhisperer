﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTextBoxAtLine : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public TextBoxManager tbm;

	public bool destroyWhenActivated;

	// Use this for initialization
	void Start () {
		tbm = FindObjectOfType<TextBoxManager> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
		Debug.Log("collision");
		if (other.tag == "Player" && Input.GetKeyDown(KeyCode.Space)) {
			tbm.ReloadScript (theText);
			tbm.currLine = startLine;
			tbm.endAtLine = endLine;
			if (destroyWhenActivated) {
				Destroy (gameObject);
			}
			tbm.EnableTextBox ();
		}
	}
}
