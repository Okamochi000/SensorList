using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// センサーリスト表示
/// </summary>
public class SensorListText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text text = this.GetComponent<Text>();
        if (text == null) { return; }

        string[] sensorNames = SensorListPlugin.GetSensorNames();
        string[] sensorTypes = SensorListPlugin.GetSensorTypes();
        if (sensorNames.Length > 0)
        {
            text.text = "[センサー一覧]";
            for (int i = 0; i < sensorNames.Length; i++)
            {
                text.text += Environment.NewLine;
                text.text += String.Format("[name = {0}][type = {1}]", sensorNames[i], sensorTypes[i]);
            }
        }
        else
        {
            text.text = "センサー無し";
        }
    }
}
