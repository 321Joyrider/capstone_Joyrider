using System.Collections;
using UnityEngine;

public class ShrinkItem : MonoBehaviour
{
    public float shrinkDuration = 5.0f; // ũ�Ⱑ �۾����� ���� �ð� (��)
    public float shrinkScale = 0.5f; // ������ �۾����� ���� (���� ũ���� ����)

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("shrinkitem"))
        {
            ShrinkCar();
            Destroy(other.gameObject); // �������� ���� �� �������� ����
        }
    }

    private void ShrinkCar()
    {
        StartCoroutine(ShrinkTimer());
    }

    private IEnumerator ShrinkTimer()
    {
        // �������� ���� �� ũ�⸦ �۾����� ��
        transform.localScale *= shrinkScale;

        // ũ�⸦ �۾����� �� ��, ���� �ð��� ������ ũ�⸦ ������� ��������
        yield return new WaitForSeconds(shrinkDuration);

        // ���� �ð��� ���� �� ũ�⸦ ������� ����
        transform.localScale /= shrinkScale;
    }
}

