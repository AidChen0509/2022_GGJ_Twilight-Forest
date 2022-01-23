using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap123 : MonoBehaviour
{
    public GameObject player;
    public GameObject monster;
    public GameObject music;
    public Sprite trapimg;
    GameObject light;
    GameObject light2;
    // Start is called before the first frame update
    void Start()
    {
        light = this.transform.GetChild(0).gameObject;
        light2 = this.transform.GetChild(1).gameObject;
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
            StartCoroutine(music1());
            other.GetComponent<playermove>().trapact = true;
            monster = GameObject.FindGameObjectWithTag("monster").gameObject;
            monster.GetComponent<Monster>().cautionset = true;
            this.gameObject.SetActive(false);
            //player.moveSpeed = moveSpeed / 2;
        }
        if (other.gameObject.tag == "light") {

            this.GetComponent<SpriteRenderer>().sprite=trapimg;
            light.gameObject.SetActive(false);
            light2.gameObject.SetActive(true);
        }
    }
    IEnumerator music1()
    {
        music.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        music.SetActive(false);

    }
}
