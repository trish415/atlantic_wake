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
        print(yval);
        transform.localScale = new Vector3(1, yval, 1);
        //transform.localScale.y = -.25*height +4.32;
	
	}
}
