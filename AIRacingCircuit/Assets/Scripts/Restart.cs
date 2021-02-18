using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject Carhold;
    public GameObject Carlist;
    // Start is called before the first frame update
    void Start(){
        Carhold = GameObject.FindGameObjectWithTag("Carholder");
        Carlist = GameObject.FindGameObjectWithTag("CarList");
    }
    public void RestartScene(){
        Destroy(Carhold);
        Destroy(Carlist);
        SceneManager.LoadScene("Racing_Circuit");
    }
}
