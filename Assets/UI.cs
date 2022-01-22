using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject beginButton;
    public GameObject replayButton;
    public GameObject firebar;
    public GameObject BackgroundBegin;
    public GameObject BackgroundMidden;
    public GameObject BackgroundEnd;
    int fire;
    float fireTime;
    //qpublic GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        fire = 0;
        fireTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateFireBar();
        /*if (player.die == true)
        {
            Time.timeScale = 1;
            beginButton.SetActive(false)
        }*/
    }

    public void begin()
    {
        fire = 0;
        beginButton.SetActive(false);
        Time.timeScale = 1;
        BackgroundBegin.SetActive(false);
    }

    public void Replay()
    {
        BackgroundMidden.SetActive(true) ;
        SceneManager.LoadScene("SampleScene");
        replayButton.SetActive(false);
        Time.timeScale = 1;
    }

    void UpdateFireBar()
    {
        fireTime += Time.deltaTime;
        if(fireTime > 2f)
        {
            Debug.Log("A");
            if (fire < 10)
            {
                firebar.transform.GetChild(fire).gameObject.SetActive(true);
                fire++;
                fireTime = 0f;
                print(fire);
            }
            else
            {
                if (Input.GetKey(KeyCode.E))
                {
                    skill();
                    fire = 0;
                }
            }
        }
    }

    void skill()
    { 
        for(int i = 0; i < 10; i++)
        {
            firebar.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
