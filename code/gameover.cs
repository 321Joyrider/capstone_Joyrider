using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public Text gameOverTimeText;

    void Start()
    {
        // ������ �浹 �ð� �ҷ�����
        float collisionTime = PlayerPrefs.GetFloat("CollisionTime", 0f);

        // �Ҽ��� ��° �ڸ����� ǥ��
        string formattedTime = string.Format("{0:F2}", collisionTime);

        // �ؽ�Ʈ�� �ð� ǥ��
        gameOverTimeText.text =formattedTime + "�� �޼�!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
