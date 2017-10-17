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

        //Debug.Log (transform.position);

        Debug.Log("pointer");
        Debug.Log (transform.forward);
        
		Ray ray = new Ray (transform.position,transform.forward);
		RaycastHit hit;
        Debug.Log("ray");
        Debug.Log(ray.direction);


        if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
			Debug.DrawLine (ray.origin, hit.point, Color.red);
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
		transform.rotation=GvrControllerInput.Orientation;
	}
}
