using UnityEngine;
using System.Collections;

public class HookSpot : MonoBehaviour {
    private GameObject h;
    private int speed = 10;
    void Start(){
        h = GameObject.Find("hook");

    }
    void OnMouseDown(){
        //while(h.transform.position.y > transform.position.y){
            float step = speed*Time.deltaTime;
            h.transform.position = Vector2.Lerp(h.transform.position, transform.position, step);
        //}

    }
}