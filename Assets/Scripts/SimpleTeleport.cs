using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTeleport : MonoBehaviour {
	public Pointer pointer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GvrControllerInput.ClickButtonDown)
			if (pointer.target != null)
			transform.position = pointer.HitPoint + Vector3.up * 10;
	}
}
