using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class breathlight : MonoBehaviour
{
    int i = 0;
    public Light2D ml;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(breath());
    }
    IEnumerator breath()
    {
        while (true)
        {
            i = 30;
            while (i >= 100)
            {
                ml.intensity = ml.intensity * 0.01f * i;
                yield return new WaitForSeconds(0.05f);
                i += 1;
            }
        } 
    }
}
