using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float repeatInterval;
    void Start()
    {
        if (repeatInterval > 0)  //스폰 간격 
        {
            InvokeRepeating("SpawnObject", 0.0f, repeatInterval);
        }

    }

    public GameObject SpawnObject()
    {
        if (prefabToSpawn != null)
        {
            return Instantiate(prefabToSpawn, transform.position, Quaternion.identity); //Quaternion.identity 객체가 생성될 때의 회전을 나타냄 
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
