using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    private LineRenderer lineRender;
    private GameObject TrackPath;

    public GameObject Car1;
    public GameObject Car2;
    public GameObject Car3;
    public GameObject Car4;
    public GameObject MiniMapCam;
    // Start is called before the first frame update
    void Start()
    {
        lineRender = GetComponent<LineRenderer>();
        TrackPath = this.gameObject;

        int num_of_path = TrackPath.transform.childCount;
        lineRender.positionCount = num_of_path + 1;

        for (int x = 0; x < num_of_path; x++)
        {
            lineRender.SetPosition(x, new Vector3(TrackPath.transform.GetChild(x).transform.position.x,
                4, TrackPath.transform.GetChild(x).transform.position.z));
        }  

        lineRender.SetPosition(num_of_path, lineRender.GetPosition(00));

        lineRender.startWidth = 7f;
        lineRender.endWidth = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
