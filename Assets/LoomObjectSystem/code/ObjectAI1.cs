/*using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        
        Goal = 0;
    }

    /*public void SpawnObject()//生成食物
    {
        if (transform.childCount < 9)
        {
            GameObject Object = Instantiate(ObjectPrefabs[0], transform);
            Object.transform.position = new Vector3(Random.Range(-8.6f, 8.29f), Random.Range(-4.3f, 4.6f), 500f);
        }
    }

    public void SpawnTrap()//生成隨機陷阱
    {
        if (transform.childCount < 11)
        {
            GameObject trap = Instantiate(TrapPrefabs[0], transform);
            trap.transform.position = new Vector3(Random.Range(-8.6f, 8.29f), Random.Range(-4.3f, 4.6f), 500f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        PointCounter();
    }

    void PointCounter()//計算分數
    {
        for (int i = 0; i < transform.childCount ; i++)
        {
            if (Object.transform.GetChild(i).tag == "LoomObject")
            {
                if(this.transform.GetChild(i).gameObject.activeSelf == false)
                {
                    Goal++;
                    goaltext.text = Goal.ToString() + "/5";
                }
            }
            
        }
        Goal = 0;
    }
}
*/