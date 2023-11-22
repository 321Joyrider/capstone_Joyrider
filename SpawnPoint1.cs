using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint1 : MonoBehaviour
{
    public GameObject itemPrefab;
    private GameObject currentSpawnedItem;

    void Start()
    {
        SpawnItem();
    }

    void SpawnItem()
    {
        currentSpawnedItem = Instantiate(itemPrefab, transform.position, Quaternion.identity);
    }

    void Update()
    {
        if (currentSpawnedItem == null)
        {
            StartCoroutine(SpawnAfterDelay(5f));
        }
    }

    IEnumerator SpawnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SpawnItem();
    }
}
