using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story1Control : MonoBehaviour
{
    public RawImage[] storypicture;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("stage1");
    }
}
