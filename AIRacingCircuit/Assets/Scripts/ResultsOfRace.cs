using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultsOfRace : MonoBehaviour
{
    GameObject firstPlace;
    float timeResult;
    public Text winnerName;
    public Text winnerTime;
     float mins, secs, millisecs;
    void Start()
    {
        firstPlace = GameObject.FindGameObjectWithTag("Carholder").GetComponent<LeaderboardSystem>().winner;
        timeResult = GameObject.FindGameObjectWithTag("Racecar").GetComponent<LapTimer>().totalTime;
        winnerName.text = firstPlace.name.Remove(0, 7);
        winnerTime.text = FormatTime(timeResult);
    }

    string FormatTime(float t){
        mins = Mathf.FloorToInt(t / 60);
        secs = Mathf.FloorToInt(t % 60);
        millisecs = (t % 1) * 1000;

        return string.Format("{0:00}:{1:00}:{2:000}", mins, secs, millisecs);
    }
}
