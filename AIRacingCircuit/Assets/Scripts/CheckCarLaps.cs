using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckCarLaps : MonoBehaviour
{
    public GameObject[] cars;
     bool carChecker;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        cars = GameObject.FindGameObjectsWithTag("Racecar");
    }

    // Update is called once per frame
    void Update()
    {
        CheckFinishedLaps();
    }

    void CheckFinishedLaps(){
        for (var i =0; i < cars.Length; i++){
            Debug.Log(cars[i].name + cars[i].GetComponent<LapTimer>().finishedRace);
            if (cars[i].GetComponent<LapTimer>().lap == 1){
                if (cars[i].GetComponent<LapTimer>().finishedRace){
                    carChecker = true;
                }else{
                    carChecker = false;
                    break;
                }
            }
        }
        if (carChecker == true){
            Debug.Log("Change");
            SceneManager.LoadScene("ResultUserInterface");
            this.gameObject.GetComponent<CheckCarLaps>().enabled = false;
        }
    }
}