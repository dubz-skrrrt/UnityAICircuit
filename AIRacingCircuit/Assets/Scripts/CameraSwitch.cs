﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraSwitch : MonoBehaviour {

    public GameObject cameraOne;
    public GameObject cameraTwo;
    public GameObject cameraThree;
    public GameObject cameraFour;
    public GameObject TimerOne;
    public GameObject TimerTwo;
    public GameObject TimerThree;
    public GameObject TimerFour;

    int pressnum = 0;
    void Start(){
        cameraOne.SetActive(true);
        cameraTwo.SetActive(false);
        cameraThree.SetActive(false);
        cameraFour.SetActive(false);
    }
    void Update()
    {
        switchCamera();
    }
    void switchCamera()
    {
        if (Input.GetKeyDown(KeyCode.D)){
            pressnum = pressnum + 1;
            if (pressnum == 1){
                StartCoroutine(TimeCoroutine());
                cameraOne.SetActive(false);
                cameraTwo.SetActive(true);
                cameraThree.SetActive(false);
                cameraFour.SetActive(false);
                TimerOne.SetActive(false);
                TimerTwo.SetActive(true);
                TimerThree.SetActive(false);
                TimerFour.SetActive(false);
            }
            else if (pressnum == 2){
                StartCoroutine(TimeCoroutine());
                cameraOne.SetActive(false);
                cameraTwo.SetActive(false);
                cameraThree.SetActive(true);
                cameraFour.SetActive(false);
                TimerOne.SetActive(false);
                TimerTwo.SetActive(false);
                TimerThree.SetActive(true);
                TimerFour.SetActive(false);
            }
            else if (pressnum == 3){
                StartCoroutine(TimeCoroutine());
                cameraOne.SetActive(false);
                cameraTwo.SetActive(false);
                cameraThree.SetActive(false);
                cameraFour.SetActive(true);
                TimerOne.SetActive(false);
                TimerTwo.SetActive(false);
                TimerThree.SetActive(false);
                TimerFour.SetActive(true);
            }
            else if (pressnum > 3){
                pressnum = 3;   
            }
        }
        else if (Input.GetKeyDown(KeyCode.A)){
            pressnum = pressnum - 1;
            if (pressnum == 0){
                StartCoroutine(TimeCoroutine());
                cameraOne.SetActive(true);
                cameraTwo.SetActive(false);
                cameraThree.SetActive(false);
                cameraFour.SetActive(false);
                TimerOne.SetActive(true);
                TimerTwo.SetActive(false);
                TimerThree.SetActive(false);
                TimerFour.SetActive(false);
            }
            else if (pressnum == 1){
                StartCoroutine(TimeCoroutine());
                cameraOne.SetActive(false);
                cameraTwo.SetActive(true);
                cameraThree.SetActive(false);
                cameraFour.SetActive(false);
                TimerOne.SetActive(false);
                TimerTwo.SetActive(true);
                TimerThree.SetActive(false);
                TimerFour.SetActive(false);
                
            }
            else if (pressnum == 2){
                StartCoroutine(TimeCoroutine());
                cameraOne.SetActive(false);
                cameraTwo.SetActive(false);
                cameraThree.SetActive(true);
                cameraFour.SetActive(false);
                TimerOne.SetActive(false);
                TimerTwo.SetActive(false);
                TimerThree.SetActive(true);
                TimerFour.SetActive(false);
            }
            else if (pressnum < 0){
                pressnum = 0;   
            }
        }
    }
    IEnumerator TimeCoroutine()
    {
        yield return new WaitForSeconds(1);
    }
}