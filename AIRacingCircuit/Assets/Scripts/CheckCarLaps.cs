using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckCarLaps : MonoBehaviour
{
    public GameObject[] cars;
    int counterCars;


    // Start is called before the first frame update
    void Start()
    {
        cars = GameObject.FindGameObjectsWithTag("Racecar");
        counterCars = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CheckFinishedLaps();
    }

    void CheckFinishedLaps(){
        

        if (counterCars == 4){
            Debug.Log("Cars finished: " + counterCars);
            //SceneManager.LoadScene("ResultUserInterface");
        }else {
            for (var i =0; i < cars.Length; i++){
                if (cars[i].GetComponent<LapTimer>().lap == 3){
                    counterCars++;
                    Debug.Log(counterCars);
                }
            }
        }
    }
}