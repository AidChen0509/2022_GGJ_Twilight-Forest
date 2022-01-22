using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehavior : MonoBehaviour
{
    //entry point
    [SerializeField] Transform monsterlocation;
    [SerializeField] Transform playerlocation;
    public Transform monsterAilocation;

    private void Start()
    {
        //gettransform system
        monsterlocation = GetComponent<Transform>();
    }
    //method
    public void idleWalking()
    {
        //design the idle walking method , let monster go to what we set

    }
    public void cautionWalking(GameObject playerLocation)
    {
        //design the monster be caution let he walk to the player location

    }
    public void crazyWalking(GameObject playerLocation)
    {
        //design the monster run fast to catch the player
    }
}
