using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWritingEffect : MonoBehaviour
{
    public float charsPerSecond = 0.2f;
    private string words;//�O�s�ݭn��ܤ�r

    private bool isActive = false;
    private float timer; //�p�ɾ�
    private Text myText;
    private int currentPos = 0;//��e���r��m

    
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        isActive = true;
        charsPerSecond = Mathf.Max(0.2f, charsPerSecond);
        myText = GetComponent<Text>();
        words = myText.text;
        myText.text = "";//���text��r�T���A�O�s��words��
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

    //���楴�r����
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
