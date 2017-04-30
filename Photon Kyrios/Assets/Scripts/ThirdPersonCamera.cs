using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    public float speed = 1;
    public Transform Target;

    public float xMax;
    public float yMax;
	// Use this for initialization
	void Update()
    {
        transform.LookAt(Target);
        transform.RotateAround(Target.position, new Vector3(0, -2, 0), Input.GetAxis("Mouse X") * Time.deltaTime * xMax);
        transform.RotateAround(Target.position, new Vector3(-5, 0, 0), Input.GetAxis("Mouse Y") * Time.deltaTime * xMax);
    }

}
