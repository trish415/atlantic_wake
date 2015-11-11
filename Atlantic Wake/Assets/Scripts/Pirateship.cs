using UnityEngine;
using System.Collections;

public class Pirateship : MonoBehaviour {
    public int hits; //can set ship difficulty in unity
    private int count;
    public float speed;
    public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
    void OnMouseDown(){
        count ++;
        if (count == hits){
            Destroy(gameObject);
        }
    }
	// Update is called once per frame
	void Update () {
	   float step = speed * Time.deltaTime;
       transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
}
