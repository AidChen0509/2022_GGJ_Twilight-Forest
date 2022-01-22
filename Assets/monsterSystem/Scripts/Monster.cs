using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;
using UnityEngine.Experimental.Rendering.Universal;


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
    public Light2D ml;
    public Transform front;
    //產程竚
    public Transform lastplayerpos;
    //砞竚à籔弘
    public float lookAngle = 90f;
    public int lookAccurate = 4;
    int pcount = 0;
    public Collider2D playerobj;
    // Start is called before the first frame update
    void Start()
    {
        //monsterAnimator = GetComponent<Animator>();
        monsterAi = monsterAisystem.GetComponent<MonsterAIsys>();
        StartCoroutine(breath());
        StartCoroutine(op());
    }
    IEnumerator op()
    {
        while (true)
        {
            if (cautionset)
            {
                if (cautionValue == 0)
                    cautionValue = 70;
                if (cautionValue<120)
                    cautionValue += 3;
                cautionset = false;
            }
            else
            {
                if (cautionValue > 0) cautionValue-=3;
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
            Collider2D Colobj = Physics2D.Raycast(dot.position, direction, lightDistance,1<<LayerMask.NameToLayer("wallgroup")).collider;
            //Debug.Log(playerobj.name);
            if (Colobj.tag == "Player")
            {
                Debug.Log("p");
                //print(playerobj.tag);
                
                cautionset = true;
            }
        }
        catch (Exception ex)
        {
            return;
        }

    }

    void statecontrol()
    {

        if (cautionValue <= 0)
        {
            cautionValue = 0;
            this.GetComponent<Pathfinding.IAstarAI>().maxSpeed = 3;
            if (cpoint)
            {

                cpoint = false;
                pcount++;
                if (pcount == point.Length) pcount = 0;
            }
            state = 0;
            //print(point.Length);
            ml.color = Color.white;
            lastplayerpos.position = monsterAi.idlemode(point[pcount]);
            /*patrolpoint.transform.position = monsterAi.idlemode(this.gameObject);
            LastplayerPosition.position = monsterAi.idlemode(this.gameObject);*/
        }
        else if (cautionValue < 100 && cautionValue > 0)
        {
            state = 1;
            ml.color = Color.red;
            lastplayerpos.position = playerobj.transform.position;
            this.GetComponent<Pathfinding.IAstarAI>().maxSpeed = 3;
            //monsterAi.cautionMode(this.gameObject);


        }
        else if (cautionValue >= 100)
        {
            state = 2;
            ml.color = Color.red;
            lastplayerpos.position = playerobj.transform.position;
            this.GetComponent<Pathfinding.IAstarAI>().maxSpeed = 5;
            //monsterAi.crazyMode(this.gameObject);
        }
    }
    
    IEnumerator breath()
    {
        int i = 0;
        i = 20;
        while (true)
        {
            
            while (i<100)
            {
                yield return new WaitForSeconds(0.01f);
                ml.intensity = 0.1f * i;
                i += 1;
            }
            print("asd");
            while (i > 20)
            {
                print(i);
                yield return new WaitForSeconds(0.01f);
                ml.intensity = 0.1f * i;
                i -= 1;
            }
        }
    }

}
