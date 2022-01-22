using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class timemanger : MonoBehaviour
{
    public float time1, time2, time3, time4;
    public GameObject light;
    public Light2D Tfl;

    // Start is called before the first frame update
    void Start()
    {
        Tfl.intensity = 0f;
        time1 = Random.Range(10,50);
        time2 = Random.Range(65, 85);
        time3 = Random.Range(92,103);
        time4 = Random.Range(113, 119);
        StartCoroutine(gametime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator gametime()
    {
        
        yield return new WaitForSeconds(time1*0.3f);
        //1
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
        Tfl.intensity = 0f;
        //1
        //2
        yield return new WaitForSeconds((time2-time1-3)*0.3f);
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
        Tfl.intensity = 0f;
        //2
        //3
        yield return new WaitForSeconds((time3 - time2-6)*0.3f);
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
        Tfl.intensity = 0f;
        //3
        //4
        yield return new WaitForSeconds((time4 - time3-9)*0.3f);
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
        Tfl.intensity = 0f;
        //4

    }
}
