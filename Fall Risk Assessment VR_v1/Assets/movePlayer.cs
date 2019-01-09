using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {

    bool safe;
	// Use this for initialization
	void Start () {
        safe = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (safe)
            {
                this.transform.position = new Vector3(-30.42f, -63f, 3.72f);
                safe = false;
            }
            else
            {
                this.transform.position = new Vector3(-30.42f, 2.65f, 3.72f);
                safe = true;
            }
        }
	}
}
