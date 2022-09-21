using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Of());
    }

    public IEnumerator Of()
    {
        yield return new WaitForSeconds(1.25f);
        gameObject.GetComponent<Light>().enabled = false;
        Debug.Log("Kapat");
        StartCoroutine(On());
    }
    public IEnumerator On()
    {
        yield return new WaitForSeconds(1.25f);
        gameObject.GetComponent<Light>().enabled = true;
        Debug.Log("Aç");
        StartCoroutine(Of());
    }
}
