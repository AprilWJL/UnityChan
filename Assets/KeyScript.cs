using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {

    public GameObject door;
    public GameObject boom;
    public GameObject pPlane3;

	private Item item;
	//private Inventory inv;

	// Use this for initialization
	void Start () {
		//inv = GameObject.Find ("Inventory").GetComponent<Inventory> ();
		item = GetComponent<Item> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void KeyCollision()
    {
        //door.transform.eulerAngles = new Vector3(0, 90, 0);
        //iTweenEvent.GetEvent(door, "doorOpen").Play();
        boom.GetComponent<ParticleSystem>().Play();     //播放粒子特效
        //Destroy(gameObject, 1.0f);
        iTweenEvent.GetEvent(pPlane3, "keyColor").Stop();
        iTweenEvent.GetEvent(gameObject, "keyScale").Stop();
		//inv.AddItem (transform);
		item.PickUpItem();
        Fungus.Flowchart.BroadcastFungusMessage("getKey");      //得到钥匙
    }

    //public void KeyExit()
    //{
    //    iTweenEvent.GetEvent(door, "doorClose").Play();
    //}
}
