using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StopWatch : MonoBehaviour
{
    public float timeStart;
    public Text textBox;
    public Text StartBtnText;
    bool timerActive = false;

    void Start()
    {
        textBox.text = timeStart.ToString("F1");
    }

    void Update()
    {
        if (timerActive){
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F1");
        }
    }
    public void timerButton()
    {
        timerActive = !timerActive;
        StartBtnText.text = timerActive ? "Stop" : "Start";
    }
}
