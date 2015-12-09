using UnityEngine;
using System.Collections;

public class HookSpot : MonoBehaviour {
    private GameObject h;
    private int speed = 5;
    void Start(){
        h = GameObject.Find("hook");

    }
    void OnMouseDown(){
        float step = speed*Time.deltaTime;
        h.transform.position = Vector2.Lerp(h.transform.position, transform.position, step);

    }
}