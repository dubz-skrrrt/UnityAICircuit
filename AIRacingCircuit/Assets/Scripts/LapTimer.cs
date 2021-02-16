﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimer : MonoBehaviour
{
    float time, totalTime;
    float mins, secs, millisecs;
    int lap = 0, prevLap = -1;
    public GameObject[] lapTimeText;
    public GameObject raceTimer;
    [SerializeField] GameObject totalTimeText;


    UnityStandardAssets.Utility.WaypointProgressTracker tracker;

    void Start()
    {
        
        tracker = this.gameObject.GetComponent<UnityStandardAssets.Utility.WaypointProgressTracker>();
        lapTimeText = GameObject.FindGameObjectsWithTag("LapText");
        totalTimeText = GameObject.FindGameObjectWithTag("TotalText");
        raceTimer = GameObject.FindGameObjectWithTag("timer");
        raceTimer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        time += Time.deltaTime;
        totalTime += Time.deltaTime;

        lapTimeText[lap].GetComponent<Text>().text = "Lap " + ((lap) + 1) + ": " + FormatTime(time);
        totalTimeText.GetComponent<Text>().text = "Total: " + FormatTime(totalTime);

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
