using UnityEngine;
using System.Collections;


public class BoatMovement : MonoBehaviour {
    private float direction;
    private int boatAngle = 4;
	// Use this for initialization
	void Start () {
	   direction  = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward*0.03f*direction);
        if ((transform.rotation.eulerAngles.z > boatAngle) || (transform.rotation.eulerAngles.z < -boatAngle)){
            direction = -direction;
            transform.Rotate(Vector3.forward*0.1f*direction);
        }
	}
}
