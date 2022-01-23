using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    public string Scene;
    public GameObject goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(GameObject.Find("ai").GetComponent<ObjectAI>().colla== GameObject.Find("ai").GetComponent<ObjectAI>().Goal&& GameObject.Find("ai").GetComponent<ObjectAI>().colla!=0)
            {
                print("asd");
                SceneManager.LoadScene(Scene);
            }
        }
    }
}
