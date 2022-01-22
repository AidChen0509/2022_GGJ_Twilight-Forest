using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectAI : MonoBehaviour
{
    public GameObject Circle;
    public int Goal;
    public Text goaltext;
    public GameObject Object;
    public GameObject[] ObjectPrefabs;
    public GameObject trap;
    public GameObject[] TrapPrefabs;
    public Transform stage_lu;
    public Transform stage_rd;
    // Start is called before the first frame update
    void Start()
    {

        Goal = 0;
    }

    public void SpawnObject()//生成食物
    {
        if (transform.childCount < 8)
        {
            GameObject Object = Instantiate(ObjectPrefabs[0], transform);
            Object.transform.position = new Vector3(Random.Range(stage_lu.position.x, stage_rd.position.x), Random.Range(stage_lu.position.y, stage_rd.position.y), -6f);
        }
    }

    public void SpawnTrap()//生成隨機陷阱
    {
        if (transform.childCount < 6)
        {
            GameObject trap = Instantiate(TrapPrefabs[0], transform);
            trap.transform.position = new Vector3(Random.Range(stage_lu.position.x, stage_rd.position.x), Random.Range(stage_lu.position.y, stage_rd.position.y), -6f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTrap();
        SpawnObject();
        //PointCounter();
    }

    /*void PointCounter()//計算分數
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (Object.transform.GetChild(i).tag == "LoomObject")
            {
                if (this.transform.GetChild(i).gameObject.activeSelf == false)
                {
                    Goal++;
                    goaltext.text = Goal.ToString() + "/5";
                }
            }

        }
        Goal = 0;
    }*/
}
