using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateAI : MonoBehaviour {

    private Inventory inv;
    private GameObject doorHigne;

    // Use this for initialization
    void Start () {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        doorHigne = transform.Find("DoorHigne1").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider col)
    {
        Fungus.Flowchart.BroadcastFungusMessage("gateSay");
    }

    private void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (inv.CheckItem("KeyGate") > 0)
            {
                iTweenEvent.GetEvent(doorHigne, "doorOpen").Play();
                inv.RemoveItem(inv.GetItem("KeyGate"));
            }
        }
    }

    private void OnTriggerExit(Collider col)
    {
        Fungus.Flowchart.BroadcastFungusMessage("exit");
    }
}
