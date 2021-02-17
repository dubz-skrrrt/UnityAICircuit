using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultsOfRace : MonoBehaviour
{
    public GameObject firstPlace;
    public Text winnerName;
    public Text winnerTime;
    void Start()
    {
        firstPlace = GameObject.FindGameObjectWithTag("Carholder").GetComponent<LeaderboardSystem>().winner;

        winnerName.text = firstPlace.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
