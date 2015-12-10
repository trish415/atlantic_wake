using UnityEngine;
using System.Collections;

public class JunkMovement : MonoBehaviour {
    private float speed;
    private float rotation;

	// Use this for initialization
	void Start () {
	   speed = Random.Range (0.01f, 0.1f);
       rotation = Random.Range(1.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	    transform.position += speed*Vector3.left;
        transform.Rotate(Vector3.forward*-rotation);
	}

    public void killJunk(){
        Destroy(gameObject);
    }
}
