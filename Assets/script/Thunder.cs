using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class Thunder : MonoBehaviour
{
    public Light2D Tfl;
    public GameObject thislight;
    //private bool lien;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (thislight.activeSelf)
        {
            print("light");
            StartCoroutine(flash());
            new WaitForSeconds(2.8f);
        }
    }
    IEnumerator flash()
    {
        //lien = false;
        Tfl.intensity = 0.3f;
        yield return new WaitForSeconds(0.25f);
        Tfl.intensity = 0f;
        yield return new WaitForSeconds(0.25f);
        Tfl.intensity = 0.3f;
        yield return new WaitForSeconds(0.25f);
        Tfl.intensity = 0f;
        yield return new WaitForSeconds(2f);
        Tfl.intensity = 1f;
        yield return new WaitForSeconds(0.15f);
     
    }
}
