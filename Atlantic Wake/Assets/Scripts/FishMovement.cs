using UnityEngine;
using System.Collections;

public class FishMovement : MonoBehaviour {
    public Camera cam;
    private float speed;
    void Start () {
        if (cam == null) {
            cam = Camera.main;
        }
        speed = Random.Range (0.01f, 0.1f);
    }

    void Update () {
        transform.position += speed*Vector3.left;
    }
}