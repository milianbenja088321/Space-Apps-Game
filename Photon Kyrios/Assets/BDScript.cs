using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BDScript : MonoBehaviour {
    public GameObject self;

	void OnTriggerEnter (Collider other)
    {
        self.SetActive(true);
    }

    void OnTriggerExit (Collider other)
    {
        self.SetActive(false);

    }




}
