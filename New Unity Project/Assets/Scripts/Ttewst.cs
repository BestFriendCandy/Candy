using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ttewst : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        StartCoroutine(Test());
    }

    IEnumerator Test()
    {
        while(true)
        {
            yield return new WaitForSeconds(5f);

            Instantiate(prefab, transform);
        }
        
    }
}
