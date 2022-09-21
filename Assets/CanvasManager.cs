using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public TextMeshProUGUI hour_TXT;
    public TextMeshProUGUI min_TXT;
    public TextMeshProUGUI sec_TXT;

    public int hour;
    public int min;
    public int sec;

    private void Update()
    {
        hour = System.DateTime.Now.Hour;
        min = System.DateTime.Now.Minute;
        sec = System.DateTime.Now.Second;

        hour_TXT.text = hour.ToString();
        min_TXT.text = min.ToString();
        sec_TXT.text = sec.ToString();
    }

}
