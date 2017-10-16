using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour {

	public GameObject PointDot;
	public GameObject target;
	public Vector3 HitPoint;
	//LineRenderer line;

	// Use this for initialization
	void Start () {
		//line = (LineRenderer)gameObject.GetComponent ("LineRenderer");
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation=GvrControllerInput.Orientation;
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
			target = hit.collider.gameObject;
			HitPoint = hit.point;
			PointDot.SetActive (true);
			PointDot.transform.position = HitPoint;
			//line.SetPosition (0, Vector3.forward * hit.distance);
		} else {
			target = null;
			PointDot.SetActive (false);
			//line.SetPosition (0, Vector3.forward * 100f);
		}

	}
}
