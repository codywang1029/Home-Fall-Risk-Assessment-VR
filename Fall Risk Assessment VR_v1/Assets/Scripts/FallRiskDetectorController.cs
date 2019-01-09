using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallRiskDetectorController : MonoBehaviour {
    //A float representing the minimum level of fall risk required for an object to be marked as a fall hazard by the detector
    public float fallRiskWarningThreshold = 0.5f;
    public GameObject redLight;
	private bool activate;
	// Use this for initialization
	void Start () {
		activate = false;
        redLight.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(activate);
       if (activate) {
		   redLight.SetActive(true);
	   }
	   else {
		   redLight.SetActive(false);
	   }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            activate = true;
        }
       

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            activate = false;
        }
    }
}
