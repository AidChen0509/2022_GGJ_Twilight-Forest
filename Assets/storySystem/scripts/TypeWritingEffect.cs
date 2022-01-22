using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWritingEffect : MonoBehaviour
{
    public float charsPerSecond = 0.2f;
    private string words;//保存需要顯示文字

    private bool isActive = false;
    private float timer; //計時器
    private Text myText;
    private int currentPos = 0;//當前打字位置

    
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        isActive = true;
        charsPerSecond = Mathf.Max(0.2f, charsPerSecond);
        myText = GetComponent<Text>();
        words = myText.text;
        myText.text = "";//獲取text文字訊息，保存到words中
    }

    // Update is called once per frame
    void Update()
    {
        OnStartWriter();
    }

    public void StartEffect()
    {
        isActive = true;
    }

    //執行打字任務
    private void OnStartWriter()
    {
        if (isActive)
        {
            timer += Time.deltaTime;
            if (timer >= charsPerSecond)
            {
                timer = 0;
                currentPos++;
                myText.text = words.Substring(0, currentPos);
                if (currentPos >= words.Length)
                {
                    OnFinish();
                }
            }
        }
        throw new NotImplementedException();
    }

    private void OnFinish()
    {
        isActive = false;
        timer = 0;
        currentPos = 0;
        myText.text = words;
        throw new NotImplementedException();
    }
}
