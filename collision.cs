using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    Text text;
    public static float count = 0;
    Timer timerInstance;


    void Start()
    {
        count = 0;
        text = GetComponent<Text>();
        timerInstance = FindObjectOfType<Timer>();
        if (timerInstance == null)
        {
            Debug.LogError("Timer 인스턴스를 찾을 수 없습니다!");
        }
    }


    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.gameObject.CompareTag("PoliceCar"))
        {
            count += 1;
            GetComponent<AudioSource>().Play();
        }






    }

    void Update()
    {
        text.text = "충돌:" + count;

        if (count == 1)
        {
            DestroyObjectsWithTag("heart5");
        }
        else if (count == 2)
        {
            DestroyObjectsWithTag("heart4");
        }
        else if (count == 3)
        {
            DestroyObjectsWithTag("heart3");
        }
        else if (count == 4)
        {
            DestroyObjectsWithTag("heart2");
        }
        else if (count == 5)
        {
            DestroyObjectsWithTag("heart1");

            float collisionTime = timerInstance != null ? timerInstance.GetCurrentTime() : 0f;
            PlayerPrefs.SetFloat("CollisionTime", collisionTime);

            SceneManager.LoadScene("GameOver");


        }
    }

    void DestroyObjectsWithTag(string tag)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);

        foreach (GameObject obj in objects)
        {
            Destroy(obj);
        }
    }




}

