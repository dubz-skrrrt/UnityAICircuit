using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ResultsOfRace : MonoBehaviour
{
    public GameObject firstPlace;
    public GameObject cars;
    float timeResult;
    public Text winnerName;
    public Text winnerTime;
     float mins, secs, millisecs;
    void Start()
    {
        firstPlace = GameObject.FindGameObjectWithTag("Carholder").GetComponent<LeaderboardSystem>().winner;
        cars = GameObject.FindGameObjectWithTag("CarList");
        timeResult = GameObject.FindGameObjectWithTag("Racecar").GetComponent<LapTimer>().totalTime;
        winnerName.text = firstPlace.name.Remove(0, 7);
        winnerTime.text = FormatTime(timeResult);
    }

    // public void RestartScene(){
    //     Destroy(firstPlace);
    //     Destroy(cars);
    //     SceneManager.LoadScene("Racing_Circuit");
    // }

    string FormatTime(float t){
        mins = Mathf.FloorToInt(t / 60);
        secs = Mathf.FloorToInt(t % 60);
        millisecs = (t % 1) * 1000;

        return string.Format("{0:00}:{1:00}:{2:000}", mins, secs, millisecs);
    }

    
}
