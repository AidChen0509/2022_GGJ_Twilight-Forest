using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patroltrigger : MonoBehaviour
{
    Monster monster = null;
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
            //Debug.Log("a");
            col.GetComponent<Monster>().cpoint = true;
            //last.GetComponent<MonsterAIsys>().p=two.transform.position;
        }
    }
}
