using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowGoal : MonoBehaviour {

	public Transform goal;
	float speed = 0;
	float minSpeed = 0.0f;
	float maxSpeed = 50.0f;
	float brakeAngle = 60.0f;
	public int accel;
	public int decel;
	public int rotSpeed;

	// Use this for initialization
	void Start () {
		accel = Random.Range(4, 6);
		decel = Random.Range(4, 6);
		rotSpeed = Random.Range(8, 10);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 lookAtGoal = new Vector3(goal.position.x, 
										this.transform.position.y, 
										goal.position.z);
		Vector3 direction = lookAtGoal - this.transform.position;

		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, 
												Quaternion.LookRotation(direction), 
												Time.deltaTime*rotSpeed);

		if (Vector3.Angle(goal.forward, this.transform.forward) > brakeAngle) {
			speed = Mathf.Clamp(speed - (decel * Time.deltaTime), minSpeed, maxSpeed);
		}else {
			speed = Mathf.Clamp(speed + (accel * Time.deltaTime), minSpeed, maxSpeed);
		}
		this.transform.Translate(0,0,speed*Time.deltaTime);

		
	}
}
