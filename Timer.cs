using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text text;
    float rTime = 0;

    public float GetCurrentTime()
    {
        return rTime;
    }

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        rTime += Time.deltaTime;

        // �Ҽ��� ��° �ڸ����� ǥ��
        string formattedTime = string.Format("{0:F2}", rTime);
        text.text = formattedTime;

        if (rTime >= 180)
        {
            SceneManager.LoadScene("Victory");
            rTime = 0;
        }
    }

    
   
}
