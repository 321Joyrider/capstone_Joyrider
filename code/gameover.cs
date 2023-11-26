using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public Text gameOverTimeText;

    void Start()
    {
        // 저장한 충돌 시간 불러오기
        float collisionTime = PlayerPrefs.GetFloat("CollisionTime", 0f);

        // 소수점 둘째 자리까지 표현
        string formattedTime = string.Format("{0:F2}", collisionTime);

        // 텍스트에 시간 표시
        gameOverTimeText.text =formattedTime + "초 달성!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
