using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap123 : MonoBehaviour
{
    public GameObject player;
    public GameObject trap;
    // Start is called before the first frame update
    void Start()
    {
        new WaitForSeconds(3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.parent.GetComponent<ObjectAI>().SpawnTrap();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("A");
            trap.SetActive(false);
            //player.moveSpeed = moveSpeed / 2;
        }
    }
}
