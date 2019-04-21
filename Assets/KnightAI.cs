using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAI : MonoBehaviour {

    private HeadLookController headController;
    private GameObject unityChan;
    private GameObject sword;


    void Start () {
        headController = gameObject.GetComponent<HeadLookController>();
        unityChan = GameObject.Find("unitychan");
        sword = transform.Find("dark_sword").gameObject;

    }
	
	// Update is called once per frame
	void Update () {
        headController.target = unityChan.transform.position + new Vector3(0, 1.5f, 0);
	}

    public void KnightSay()
    {
        Fungus.Flowchart.BroadcastFungusMessage("knightGive");
    }

    public void GiveSword()
    {
		sword.SetActive (true);
        sword.GetComponent<Item>().PickUpItem();
    }
}
