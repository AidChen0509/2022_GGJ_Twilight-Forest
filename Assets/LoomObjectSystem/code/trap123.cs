using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap123 : MonoBehaviour
{
    public GameObject player;
    public GameObject trap;
    public GameObject monster;
    public Sprite trapimg;
    // Start is called before the first frame update
    void Start()
    {
        //new WaitForSeconds(3f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.parent.GetComponent<ObjectAI>().SpawnTrap();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("a");
            other.GetComponent<playermove>().trapact = true;
            monster = GameObject.FindGameObjectWithTag("monster").gameObject;
            monster.GetComponent<Monster>().cautionset = true;
            trap.SetActive(false);
            //player.moveSpeed = moveSpeed / 2;
        }
        if (other.gameObject.tag == "light") {
            trap.GetComponent<SpriteRenderer>().sprite=trapimg;
            trap.GetComponent<SpriteRenderer>().color= new Color(0.2782448f, 0.8301887f, 0.2232111f, 1.0f);
        }
    }
}
