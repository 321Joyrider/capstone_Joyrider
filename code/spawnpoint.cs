using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float repeatInterval;
    void Start()
    {
        if (repeatInterval > 0)  //���� ���� 
        {
            InvokeRepeating("SpawnObject", 0.0f, repeatInterval);
        }

    }

    public GameObject SpawnObject()
    {
        if (prefabToSpawn != null)
        {
            return Instantiate(prefabToSpawn, transform.position, Quaternion.identity); //Quaternion.identity ��ü�� ������ ���� ȸ���� ��Ÿ�� 
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}