using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardSystem : MonoBehaviour
{
    public List<GameObject> cars = new List<GameObject>();

    float first, second, third;
    public float fourth;
    List<float> carDistances = new List<float>();
    List<float> orderedDistances = new List<float>();
    Text[] leaderboardText;
    UnityStandardAssets.Utility.WaypointProgressTracker tracker;
    // Start is called before the first frame update
    void Start()
    {
        leaderboardText = this.gameObject.GetComponentsInChildren<Text>();
        foreach(GameObject car in cars){
            tracker = car.gameObject.GetComponent<UnityStandardAssets.Utility.WaypointProgressTracker>();
            carDistances.Add(tracker.progressDistance);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject car in cars){
            tracker = car.gameObject.GetComponent<UnityStandardAssets.Utility.WaypointProgressTracker>();
            carDistances[cars.IndexOf(car)] = tracker.progressDistance;
        }

        orderedDistances = carDistances.OrderByDescending(i => i).ToList();

        first = carDistances.Max();
        second = orderedDistances[1];
        third = orderedDistances[2];
        fourth = carDistances.Min();

        if(fourth > 0f){
            leaderboardText[1].text = "1st: " + cars[carDistances.IndexOf(first)].name.Remove(0, 7);
            leaderboardText[2].text = "2nd: " + cars[carDistances.IndexOf(second)].name.Remove(0, 7);
            leaderboardText[3].text = "3rd: " + cars[carDistances.IndexOf(third)].name.Remove(0, 7);
            leaderboardText[4].text = "4th: " + cars[carDistances.IndexOf(fourth)].name.Remove(0, 7);
            
        }
    }
}
