using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallRiskObjectController : MonoBehaviour {
    public float fallRisk = 0f; 
    //float from 0-1 indicating level of fall risk
    //maybe a percentage chance that it will cause a fall
    //0% is 0, means no fall risk
    //100% is 1, means almost guaranteed to cause a fall if you come into contact with object

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setFallRisk(float newFallRisk)
    {
        fallRisk = newFallRisk;
    }

    public float getFallRisk()
    {
        return fallRisk;
    }
}
