using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartMenu : MonoBehaviour
{
  void Start() {
    Time.timeScale = 0;
  }

  public void PlayGame(){
    //Debug.Log("Start");
  }

  public void QuitGame(){
    Debug.Log("Quit Game");
    Application.Quit();
  }

}
