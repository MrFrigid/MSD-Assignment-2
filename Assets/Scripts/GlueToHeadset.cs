using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueToHeadset : MonoBehaviour {

	public GameObject Camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (Camera.transform.position);
		//Debug.Log (Camera.transform.forward);
		//Debug.Log (Camera.transform.up);

		transform.position =  Camera.transform.position+  Camera.transform.forward*2.5f -  Camera.transform.up;
		transform.rotation = transform.rotation*Camera.transform.rotation;
		//Debug.Log (transform.position);
	}
}
