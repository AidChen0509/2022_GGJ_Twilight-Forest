using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAIsys : MonoBehaviour
{
    public GameObject LastplayerLocation;
    public GameObject playeringame;
    public GameObject patrol;
    public MonsterBehavior Mbehavior;
    public Monster mm;
    public GameObject[] point;
    public Vector3 p;
    public bool cpoint;
    // Start is called before the first frame update
    void Start()
    {
        p = patrol.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal Vector3 idlemode(GameObject monsterObject)
    {
        //·í¥Ø¼Ð
        Vector3 transform1 = monsterObject.transform.position;
        return transform1;
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
