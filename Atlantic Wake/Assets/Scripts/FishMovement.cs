using UnityEngine;
using System.Collections;

public class FishMovement : MonoBehaviour {
    public Camera cam;
    private Vector2 endPosition;
    private float speed;
    void Start () {
        if (cam == null) {
            cam = Camera.main;
        }
        endPosition = new Vector2 (-10, Random.Range(-4, 1));
        speed = Random.Range (0.01f, 0.1f);
    }
    //void OnMouseDown() {
    //    Destroy(gameObject);
    //}
    void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.Lerp(transform.position, endPosition, step);
    }
}