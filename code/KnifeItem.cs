using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeItem : MonoBehaviour
{
    private float rotationSpeed = 100.0f; // �ν�Ʈ ������ ȸ�� �ӵ�
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

}
