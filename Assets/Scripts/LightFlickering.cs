using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickering : MonoBehaviour
{
    [SerializeField] private Light light;

    private void Start()
    {
        StartCoroutine(Flickering());
    }

    private IEnumerator Flickering()
    {
        while (true)
        {
            for (int i = 0; i < 20; i++)
            {
                light.intensity += 1;
                yield return new WaitForSeconds(0.2f);
            }
            for (int i = 0; i < 20; i++)
            {
                light.intensity -= 1;
                yield return new WaitForSeconds(0.2f);
            }


            for (int i = 0; i < 6; i++)
            {
                light.intensity += 5;
                yield return new WaitForSeconds(0.2f);
                light.intensity -= 5;
                yield return new WaitForSeconds(0.2f);
            }


            for (int i = 0; i < 10; i++)
            {
                light.intensity += 3;
                yield return new WaitForSeconds(0.1f);
            }
            for (int i = 0; i < 10; i++)
            {
                light.intensity -= 3;
                yield return new WaitForSeconds(0.4f);
            }
        }
    }
}
