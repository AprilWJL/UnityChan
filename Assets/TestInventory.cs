using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInventory : MonoBehaviour {

	private Inventory inv;

	// Use this for initialization
	void Start () {
		inv = GameObject.Find ("Inventory").GetComponent<Inventory> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.G)) {
			if (inv.CheckItem ("Key") > 0) {
				print ("you have a key");
			}
			else {
				print ("you don't have a key");
			}
		}
	}
}
