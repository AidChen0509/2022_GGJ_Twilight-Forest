using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAIsys : MonoBehaviour
{
    public GameObject LastplayerLocation;
    public GameObject playeringame;
    public MonsterBehavior Mbehavior;
    public Monster mm;
    

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
        //·í¥Ø¼Ð
        mm = monsterObject.GetComponent<MonsterBehavior>();
        
        
        
        throw new NotImplementedException();
    }

    internal void cautionMode(GameObject monsterObject)
    {
        
        LastplayerLocation.transform.position = playeringame.transform.position;
        mm = monsterObject.GetComponent<MonsterBehavior>();


        throw new NotImplementedException();
    }

    internal void crazyMode(GameObject monsterObject)
    {
        LastplayerLocation.transform.position = playeringame.transform.position;
        monsterObject.GetComponent <MonsterBehavior>().crazyWalking(LastplayerLocation); 
        throw new NotImplementedException();
    }
}
