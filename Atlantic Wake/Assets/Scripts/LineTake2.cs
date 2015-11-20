using UnityEngine;
using System.Collections;

public class LineTake2 : MonoBehaviour {
    private GameObject h;
	// Use this for initialization
	void Start () {
	   h = GameObject.Find("hook");
	}
	
	// Update is called once per frame
	void Update () {
        float height = h.transform.position.y;
        float yval = 4.32F - height;
        transform.localScale = new Vector3(1, yval, 1);
	}
}
