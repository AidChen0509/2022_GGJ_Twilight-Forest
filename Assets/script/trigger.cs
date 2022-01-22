using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject food;
    public Collider2D foodcolider;

    // Start is called before the first frame update
    void Start()
    {
        food.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            food.SetActive(false);
        }
    }

}