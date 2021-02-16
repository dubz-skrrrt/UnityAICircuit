using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HoverButton : MonoBehaviour
{

    public RawImage startButton;
    public RawImage quitButton;
   public void ChangeColor(){
       Debug.Log("Point");
       startButton.GetComponent<RawImage>().color = Color.gray;
   }
}
