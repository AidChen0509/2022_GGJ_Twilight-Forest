using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story1Control : MonoBehaviour
{
    public RawImage[] storypicture;
    public Button nextbutton;
    public int maxtime = 30;
    public string nextScenename = "";

    //�p��
    float timer_f;
    int timer_i;
    int futuretime;
    // Start is called before the first frame update
    void Start()
    {
        nextbutton.gameObject.SetActive(false);
        timer_f = Time.time;
        timer_i = Mathf.FloorToInt(timer_f);
        futuretime = timer_i + maxtime;
    }

    // Update is called once per frame
    void Update()
    {
        timer_f = Time.time;
        timer_i = Mathf.FloorToInt(timer_f);
        Debug.Log(timer_i);
        
        if(timer_i == futuretime)
        {
            
            nextbutton.gameObject.SetActive(true);
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(nextScenename);
    }
}
