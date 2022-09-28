using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeDown : MonoBehaviour
{
    public float timeValue = 90;
    public Text timerText;
    public Text StartBtnText;
    private bool activateTimer;
    private Button button;

    private void ActivateTimer() => activateTimer = true;

    private void OnEnable()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ActivateTimer);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(ActivateTimer);
    }
    void Update()
    {

        if (activateTimer == true)
        {


            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;
            }
            DisplayTime(timeValue);

            void DisplayTime(float timeToDisplay)
            {
                if (timeToDisplay < 0)
                {
                    timeToDisplay = 0;
                }

                float minutes = Mathf.FloorToInt(timeToDisplay / 60);
                float seconds = Mathf.FloorToInt(timeToDisplay % 60);

                timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
        }
    }
    }
    



