using UnityEngine;
using System.Collections;

public class FishMovement : MonoBehaviour {
    public float speed; //public shows up in inspector to edit
    public Transform target;

	// Use this for initialization
	void Start () {

	}
    
    void OnMouseDown() {
        Destroy(gameObject);
    }
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButtonDown(0)){
        //    gameObject.SetActive(false);
        //}
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
}


