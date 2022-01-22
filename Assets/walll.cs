using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "trap")
        {

            other.transform.position = new Vector3(Random.Range(-8.6f, 8.29f), Random.Range(-4.3f, 4.6f), 500f);
        }
        if (other.gameObject.tag == "LoomObject") {

            other.transform.position = new Vector3(Random.Range(-8.6f, 8.29f), Random.Range(-4.3f, 4.6f), 500f);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
