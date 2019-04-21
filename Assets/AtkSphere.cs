using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkSphere : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("打到人了");
        }
    }


}
