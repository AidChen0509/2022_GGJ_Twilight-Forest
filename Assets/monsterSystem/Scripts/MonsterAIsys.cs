using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAIsys : MonoBehaviour
{
    public GameObject playerLocation;
    public GameObject playeringame;
    public MonsterBehavior Mbehavior;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void idlemode(GameObject monsterObject)
    {
        monsterObject.GetComponent<MonsterBehavior>().idleWalking();
        
        
        throw new NotImplementedException();
    }

    internal void cautionMode(GameObject monsterObject)
    {
        playerLocation.transform.position = playeringame.transform.position;
        monsterObject.GetComponent<MonsterBehavior>().cautionWalking(playerLocation);
        
        throw new NotImplementedException();
    }

    internal void crazyMode(GameObject monsterObject)
    {
        playerLocation.transform.position = playeringame.transform.position;
        monsterObject.GetComponent <MonsterBehavior>().crazyWalking(playerLocation); 
        throw new NotImplementedException();
    }
}
