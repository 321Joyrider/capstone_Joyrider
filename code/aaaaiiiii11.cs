using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class aaaaiiiii11 : MonoBehaviour
{
    public string targetTag = "mycar"; // 찾을 대상의 태그
    NavMeshAgent nav;

    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 대상 태그를 가진 모든 오브젝트를 찾아서 배열에 저장
        GameObject[] targetObjects = GameObject.FindGameObjectsWithTag(targetTag);

        
        GameObject selectedTarget = targetObjects[Random.Range(0, targetObjects.Length)];

            
        nav.SetDestination(selectedTarget.transform.position);

        

    }
}
