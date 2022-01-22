using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patroltrigger2 : MonoBehaviour
{
    Monster monster = null;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject last;
    // Start is called before the first frame update
    void Start()
    {
        monster = GameObject.Find("monster").GetComponent<Monster>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "monster")
        {
            last.GetComponent<MonsterAIsys>().p= three.transform.position;
        }
    }
}
