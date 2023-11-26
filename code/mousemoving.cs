using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemoving : MonoBehaviour
{
    private static mousemoving selectedCar; // ������ ���õ� �ڵ����� �����ϱ� ���� ����
    private Vector3 originalScale;
    void Start()
    {
        originalScale = transform.localScale;
    }
    private void OnMouseDown()
    {
        // ���� �ڵ����� ���õǾ� ���� ���� ���
        if (selectedCar != this)
        {
            // ������ ���õ� �ڵ����� �ִٸ� ũ�⸦ ������� ����
            if (selectedCar != null)
            {
                selectedCar.DeselectCar();
            }

            // ���� �ڵ����� ���� ���·� ����
            SelectCar();
        }
    }
    void Update()
    {

    }

    private void SelectCar()
    {
        // �ڵ��� ũ�⸦ Ű��
        transform.localScale = Vector3.Scale(originalScale, new Vector3(1.3f, 1.3f, 1.3f));

        selectedCar = this;
        Debug.Log("�ڵ��� ���õ�");
    }

    private void DeselectCar()
    {
        // �ڵ��� ũ�⸦ ������� ����
        transform.localScale = originalScale;
        selectedCar = null;
        Debug.Log("�ڵ��� ���� ������");
    }

    

    // Update is called once per frame
   
}

