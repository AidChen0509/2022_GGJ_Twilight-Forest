using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    public Text timerui;
    public int finish;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timmer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator timmer()
    {
        for(int i=0; i<finish;i++)
        {
            yield return new WaitForSeconds(0.3f);
            timerui.text = "time:" + i;
        }
    }
}
