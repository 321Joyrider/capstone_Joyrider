using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class aaaaiiiii11 : MonoBehaviour
{
    public string targetTag = "mycar"; // ã�� ����� �±�
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
        // ��� �±׸� ���� ��� ������Ʈ�� ã�Ƽ� �迭�� ����
        GameObject[] targetObjects = GameObject.FindGameObjectsWithTag(targetTag);

        
        GameObject selectedTarget = targetObjects[Random.Range(0, targetObjects.Length)];

            
        nav.SetDestination(selectedTarget.transform.position);

        

    }
}
