using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialChange : MonoBehaviour {

    public float time;
    public Renderer bulb;
    public bool isOn = true;
	// Use this for initialization
	void OnTriggerEnter()
    {
        bulb.material.color = Color.yellow;
    }

    void OnTriggerExit()
    {
        bulb.material.color = Color.white;
    }
}
