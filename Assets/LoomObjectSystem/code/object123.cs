using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class object123 : MonoBehaviour
{
    public GameObject Circle;
    // Start is called before the first frame update
    void Start()
    {
       // new WaitForSeconds(1f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.parent.GetComponent<ObjectAI>().SpawnObject();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Circle.SetActive(false);
        }
    }
}
