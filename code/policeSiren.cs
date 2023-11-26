using System.Collections;
using UnityEngine;

public class policeSiren : MonoBehaviour
{
    public GameObject RedLight, BlueLight;
    public float waitTime = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Siren());
    }

    IEnumerator Siren()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);

            RedLight.SetActive(true);
            BlueLight.SetActive(false);

            yield return new WaitForSeconds(waitTime);

            RedLight.SetActive(false);
            BlueLight.SetActive(true);
        }
    }
}