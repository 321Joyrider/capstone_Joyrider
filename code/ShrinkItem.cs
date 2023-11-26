using System.Collections;
using UnityEngine;

public class ShrinkItem : MonoBehaviour
{
    public float shrinkDuration = 5.0f; // 크기가 작아지는 지속 시간 (초)
    public float shrinkScale = 0.5f; // 차량이 작아지는 정도 (현재 크기의 비율)

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shrinkitem"))
        {
            ShrinkCar();
            Destroy(other.gameObject); // 아이템을 먹은 후 아이템을 삭제
        }
    }

    private void ShrinkCar()
    {
        StartCoroutine(ShrinkTimer());
    }

    private IEnumerator ShrinkTimer()
    {
        // 아이템을 먹은 후 크기를 작아지게 함
        transform.localScale *= shrinkScale;

        // 크기를 작아지게 한 후, 일정 시간이 지나면 크기를 원래대로 돌려놓음
        yield return new WaitForSeconds(shrinkDuration);

        // 일정 시간이 지난 후 크기를 원래대로 돌림
        transform.localScale /= shrinkScale;
    }
}

