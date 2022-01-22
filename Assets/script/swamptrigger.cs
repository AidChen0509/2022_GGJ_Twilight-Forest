using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swamptrigger : MonoBehaviour
{
    playermove player = null;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").GetComponent<playermove>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            player.speed = 2;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        player.speed = 15;
    }
}
