using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -16f, 16f),
        Mathf.Clamp(transform.position.y, -10f, 10f), transform.position.z);
		
		if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
	}
}
