using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class Monster : MonoBehaviour
{
    
    //public Animator monsterAnimator;
    [SerializeField] MonsterAIsys monsterAi;
    public GameObject monsterAisystem;

    //stat 把计籔caution计
    public int state = 0;
    public bool cautionset = false;
    public int cautionValue = 0;
    public bool IsCatchedPlayer = false;
    public Transform dot;
    public GameObject[] point;
    public bool cpoint;
    //絬禯瞒
    public float lightDistance = 3.0f;
    public Transform front;
    //產程竚
    public Transform lastplayerpos;
    //砞竚à籔弘
    public float lookAngle = 90f;
    public int lookAccurate = 4;
    int pcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //monsterAnimator = GetComponent<Animator>();
        monsterAi = monsterAisystem.GetComponent<MonsterAIsys>();



        StartCoroutine(op());
    }
    IEnumerator op()
    {
        while (true)
        {
            if (cautionset)
            {
                cautionValue += 7;
            }
            else
            {
                if (cautionValue > 0) cautionValue--;
            }
            yield return new WaitForSeconds(0.1f);
        }

    }


    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(front.position.x - dot.position.x, front.position.y - dot.position.y);


        lightcatched(direction);
        statecontrol();

    }

    private void lightcatched(Vector2 directon2)
    {
        //セ絬
        rayLook(directon2);
        //Debug.Log("c");
        //肂絬
        float subangle = (lookAngle / 2) / lookAccurate;
        Vector2 offsetlight = new Vector2(Mathf.Cos(subangle), Mathf.Sin(subangle));
        Vector2 offsetlight2 = new Vector2(Mathf.Sin(subangle), Mathf.Cos(subangle));
        //Debug.Log("B");
        for (int i = 0; i < lookAccurate; i++)
        {
            //Debug.Log("A");
            rayLook(directon2 + offsetlight * i);
            rayLook(directon2 - offsetlight * i);
            rayLook(directon2 + offsetlight2 * i);
            rayLook(directon2 - offsetlight2 * i);

        }

        
    }

    private void rayLook(Vector2 direction)
    {
        Debug.DrawRay(dot.position, direction, Color.green, 0.01f);
        try
        {
            Collider2D playerobj = Physics2D.Raycast(dot.position, direction, lightDistance).collider;
            
            if (playerobj.tag == "Player")
            {
                print(playerobj.tag);
                lastplayerpos.position = playerobj.transform.position;
                cautionset = true;
            }
            else
                cautionset = false;
        }
        catch (Exception ex)
        {
            return;
        }

    }

    void statecontrol()
    {

        if (cautionValue == 0)
        {
            this.GetComponent<Pathfinding.IAstarAI>().maxSpeed = 3;
            if (cpoint)
            {

                cpoint = false;
                pcount++;
                if (pcount == point.Length) pcount = 0;
            }
            state = 0;
            //print(point.Length);
            lastplayerpos.position = monsterAi.idlemode(point[pcount]);
            /*patrolpoint.transform.position = monsterAi.idlemode(this.gameObject);
            LastplayerPosition.position = monsterAi.idlemode(this.gameObject);*/
        }
        else if (cautionValue < 100 && cautionValue > 0)
        {
            state = 1;
            this.GetComponent<Pathfinding.IAstarAI>().maxSpeed = 3;
            //monsterAi.cautionMode(this.gameObject);
        }
        else if (cautionValue >= 100)
        {
            state = 2;
            this.GetComponent<Pathfinding.IAstarAI>().maxSpeed = 5;
            //monsterAi.crazyMode(this.gameObject);
        }
    }

    

}
