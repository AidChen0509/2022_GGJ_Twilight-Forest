using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryBegin : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startmenu()
    {
        SceneManager.LoadScene("Storyscene1");
    }
    public void endgame()
    {
        Application.Quit();
    }
}
