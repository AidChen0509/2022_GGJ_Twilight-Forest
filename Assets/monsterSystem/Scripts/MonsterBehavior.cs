using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehavior : Monster
{
    //entry point
    [SerializeField] GameObject monsterlocation;
    [SerializeField] GameObject playerlocation;
    public Transform[] monsterLocation1;

    
    private void Start()
    {
        //gettransform system
        
        
    }
    //method
    public void idleWalking(GameObject lastplayerLocation)
    {
        //design the idle walking method , let monster go to what we set
        

    }
    public void cautionWalking(GameObject lastplayerLocation)
    {
        //design the monster be caution let he walk to the player location

    }
    public void crazyWalking(GameObject playerLocation)
    {
        //design the monster run fast to catch the player
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(state == 1 && collision.tag == "Player")
        {
            //gameover
        }
        else
        {

        }
    }
}
