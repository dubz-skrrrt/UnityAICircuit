using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 3f;
    
    public GameObject raceTimer;
    public GameObject leaderboard;
    public GameObject miniMap;
   
    [SerializeField] Text CountdownText;

    // Start is called before the first frame update
    void Start()
    {
      
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.unscaledDeltaTime;
        CountdownText.text  = currentTime.ToString("0");

        if(currentTime <= 1){
            currentTime = 1;
            CountdownText.enabled = false;
            Time.timeScale = 1;
            raceTimer.SetActive(true);
            leaderboard.SetActive(true);
            miniMap.SetActive(true);
            //  CountdownText.text  = currentTime.ToString("Go!");  
            // DisableText();        
        }
    }
}
