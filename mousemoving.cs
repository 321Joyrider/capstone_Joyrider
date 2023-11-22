using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemoving : MonoBehaviour
{
    private static mousemoving selectedCar; // 이전에 선택된 자동차를 추적하기 위한 변수
    private Vector3 originalScale;
    void Start()
    {
        originalScale = transform.localScale;
    }
    private void OnMouseDown()
    {
        // 현재 자동차가 선택되어 있지 않은 경우
        if (selectedCar != this)
        {
            // 이전에 선택된 자동차가 있다면 크기를 원래대로 돌림
            if (selectedCar != null)
            {
                selectedCar.DeselectCar();
            }

            // 현재 자동차를 선택 상태로 변경
            SelectCar();
        }
    }
    void Update()
    {

    }

    private void SelectCar()
    {
        // 자동차 크기를 키움
        transform.localScale = Vector3.Scale(originalScale, new Vector3(1.3f, 1.3f, 1.3f));

        selectedCar = this;
        Debug.Log("자동차 선택됨");
    }

    private void DeselectCar()
    {
        // 자동차 크기를 원래대로 돌림
        transform.localScale = originalScale;
        selectedCar = null;
        Debug.Log("자동차 선택 해제됨");
    }

    

    // Update is called once per frame
   
}

