using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackpadMovement : MonoBehaviour {

    Transform mycamera;
    Vector3 direction;
    Vector3 temp_dir;
    public float speed;

    // Use this for initialization
    void Start()
    {
        mycamera = transform.Find("Main Camera");

    }

    // Update is called once per frame
    void Update()
    {
        
        if (GvrControllerInput.IsTouching && GvrControllerInput.TouchPosCentered.x * GvrControllerInput.TouchPosCentered.x + GvrControllerInput.TouchPosCentered.y * GvrControllerInput.TouchPosCentered.y >= 0.25)
        {
            speed = 5 * (GvrControllerInput.TouchPosCentered.x * GvrControllerInput.TouchPosCentered.x + GvrControllerInput.TouchPosCentered.y * GvrControllerInput.TouchPosCentered.y);
            direction = Vector3.ProjectOnPlane(mycamera.forward, Vector3.up).normalized;
            temp_dir = new Vector3(GvrControllerInput.TouchPosCentered.x, 0, GvrControllerInput.TouchPosCentered.y);
            temp_dir = temp_dir.normalized;
            Quaternion q = Quaternion.FromToRotation(Vector3.forward, temp_dir);
            direction = q * direction;
            direction = direction.normalized * speed;
            mycamera.Translate(direction * Time.deltaTime);
        }
        */
        
        if (GvrControllerInput.IsTouching)
        {
            speed = 5;
            direction = Vector3.ProjectOnPlane(mycamera.forward, Vector3.up).normalized;
            temp_dir = new Vector3(0, 0, 1);
            temp_dir = temp_dir.normalized;
            Quaternion q = Quaternion.FromToRotation(Vector3.forward, temp_dir);
            direction = q * direction;
            direction = direction.normalized * speed;
            mycamera.Translate(direction * Time.deltaTime);
        }
        */
    }
}
