using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimer : MonoBehaviour
{
    float time, totalTime;
    float mins, secs, millisecs;
    int lap = 0, prevLap = -1;
    public GameObject raceTimer;

    Text[] lapTimeText;
    Text totalTimeText;

    UnityStandardAssets.Utility.WaypointProgressTracker tracker;

    void Start()
    {
        tracker = this.gameObject.GetComponent<UnityStandardAssets.Utility.WaypointProgressTracker>();
        raceTimer = this.gameObject.transform.GetChild(8).gameObject;
        lapTimeText = raceTimer.GetComponentsInChildren<Text>();
        totalTimeText = lapTimeText[lapTimeText.Length - 1];
        raceTimer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        time += Time.deltaTime;
        totalTime += Time.deltaTime;

        lapTimeText[lap].text = "Lap " + ((lap) + 1) + ": " + FormatTime(time);
        totalTimeText.text = "Total: " + FormatTime(totalTime);

        if(tracker.progressDistance >= 630f){
            lap = ((int)tracker.progressDistance) / 630;

            if(lap > prevLap){
                lapTimeText[lap-1].GetComponent<Text>().text = "Lap " + (lap) + ": " + FormatTime(time);
                prevLap = lap;
                time = 0f;
            }
            Debug.Log(lap);
        }

    }

    string FormatTime(float t){
        mins = Mathf.FloorToInt(t / 60);
        secs = Mathf.FloorToInt(t % 60);
        millisecs = (t % 1) * 1000;

        return string.Format("{0:00}:{1:00}:{2:000}", mins, secs, millisecs);
    }
}
