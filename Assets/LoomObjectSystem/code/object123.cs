using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class object123 : MonoBehaviour
{
    public GameObject Circle;
    GameObject light ;
    // Start is called before the first frame update
    void Start()
    {
        light = this.transform.GetChild(0).gameObject;
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
        if (other.gameObject.tag == "light") 
        {
            print("a");
            light.GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>().intensity =2.2f;
        }
    }
}
