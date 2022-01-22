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
    
    //stat 參數與caution數值
    public int state = 0;
    public int cautionValue = 0;
    public bool IsCatchedPlayer = false;
    public Ray2D lightray;
    
    // Start is called before the first frame update
    void Start()
    {
        //monsterAnimator = GetComponent<Animator>();
        monsterAi = monsterAisystem.GetComponent<MonsterAIsys>();

        
    }

    // Update is called once per frame
    void Update()
    {
        statecontrol();

    }

    void statecontrol()
    {
        if (cautionValue == 0)
        {
            monsterAi.idlemode(this.gameObject);
            
        }
        else if (cautionValue < 100 && cautionValue > 0)
        {
            monsterAi.cautionMode(this.gameObject);
                       
        }else if (cautionValue == 100)
        {
            monsterAi.crazyMode(this.gameObject);
        }
    }

    

}
