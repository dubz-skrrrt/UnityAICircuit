using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    public UnityStandardAssets.Utility.WaypointCircuit circuit;

    int curWP = 0;
    float accuracy = 1.0f;
    // float accel = 5f;
    // float decel = 10f;
    // float minSpeed = 0f;
    // float maxSpeed = 100f;
    // float breakAngle = 20f;
    float speed = 2f;
    float rotSpeed = 1f;
    // Start is called before the first frame update
    void Start(){

    }
    // Update is called once per frame
    void Update()
    {
        if (circuit.Waypoints.Length == 0) return;

        Vector3 lookAtGoal = new Vector3(circuit.Waypoints[curWP].transform.position.x, this.transform.position.y, circuit.Waypoints[curWP].transform.position.z);

        Vector3 direction = lookAtGoal = this.transform.position;

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime*rotSpeed);

        if (direction.magnitude < accuracy) {
            curWP++;
            if (curWP >= circuit.Waypoints.Length) {
                curWP = 0;
            }
        }
        this.transform.Translate(0,0, speed*Time.deltaTime);
    }
}
