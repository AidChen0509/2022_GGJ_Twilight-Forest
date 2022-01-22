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
    public int cautionValue = 0;
    public bool IsCatchedPlayer = false;

    //絬禯瞒
    public float lightDistance = 3.0f;
    //產程竚
    public Transform LastplayerPosition;
    //砞竚à籔弘
    public float lookAngle = 90f;
    public int lookAccurate = 4;
    
    // Start is called before the first frame update
    void Start()
    {
        //monsterAnimator = GetComponent<Animator>();
        monsterAi = monsterAisystem.GetComponent<MonsterAIsys>();
        



    }

    
    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2( LastplayerPosition.position.x - this.transform.position.x, LastplayerPosition.position.y - this.transform.position.y);


        lightcatched(direction);
        statecontrol();

    }

    private void lightcatched(Vector2 directon2)
    {
        //セ絬
        rayLook(directon2);

        //肂絬
        float subangle = (lookAngle / 2)/lookAccurate;
        Vector2 offsetlight = new Vector2(Mathf.Cos(subangle), Mathf.Sin(subangle));
        for(int i = 0; i < lookAccurate; i++)
        {
            Debug.Log("A");
            rayLook(directon2 + offsetlight * i);
            rayLook(directon2 - offsetlight * i);
        }

        
    }

    private void rayLook(Vector2 direction)
    {
        Debug.DrawRay(this.transform.position, direction, Color.green, lightDistance);
        
        if (Physics2D.Raycast(this.transform.position, direction, lightDistance).collider.tag == "Player")
        {
            cautionValue += 10;
        }
        
    }

    void statecontrol()
    {

        if (cautionValue == 0)
        {
            state = 0;
            monsterAi.idlemode(this.gameObject);
            
        }
        else if (cautionValue < 100 && cautionValue > 0)
        {
            state = 1;
            monsterAi.cautionMode(this.gameObject);
                       
        }else if (cautionValue == 100)
        {
            state = 2;
            monsterAi.crazyMode(this.gameObject);
        }
    }

    

}
