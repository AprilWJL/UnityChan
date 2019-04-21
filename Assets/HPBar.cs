using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour {


	void Start () {
		
	}

	void Update () {
        transform.rotation = Camera.main.transform.rotation;    //血条方向朝向摄像机
	}
}
