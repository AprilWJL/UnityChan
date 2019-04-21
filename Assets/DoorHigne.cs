using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHigne : MonoBehaviour {

	private Inventory inv;

	// Use this for initialization
	void Start () {
        //transform.eulerAngles = new Vector3(0, 0, 0);
		inv = GameObject.Find("Inventory").GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
   //     if (Input.GetKeyDown(KeyCode.O))
   //     {
			//if (inv.CheckItem("KeyGate") > 0) {
			//	iTweenEvent.GetEvent(gameObject, "doorOpen").Play();
			//	inv.RemoveItem(inv.GetItem ("KeyGate"));
			//}
   //     }

   //     if (Input.GetKeyDown(KeyCode.C))
   //     {
   //         iTweenEvent.GetEvent(gameObject, "doorClose").Play();
   //     }



    }

}
