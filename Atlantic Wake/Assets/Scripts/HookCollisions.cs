using UnityEngine;
using System.Collections;

public class HookCollisions : MonoBehaviour {
    private GameObject[] boxes;
    private BoxCollider2D[] colliders;
    private int numBoxes = 20;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(-2.23F, 3.75F, 0);
        boxes = new GameObject[numBoxes];
        colliders = new BoxCollider2D[numBoxes];
        for  (int i = 0; i < numBoxes; i++)
        {
            boxes[i] = new GameObject();
            //set height, width
            float ySpot = 1.9F - i*0.32F;
            boxes[i].transform.position = new Vector3(transform.position.x, ySpot ,0);
            //add script for hook to move
            boxes[i].AddComponent<HookSpot>();
            //add collision box
            colliders[i] = boxes[i].AddComponent<BoxCollider2D>();
            colliders[i].size = new Vector2(1F, 0.32F);
        }
	}
	
   void OnCollisionEnter (Collision col)
    {
        if((col.gameObject.name == "RedFish2")||(col.gameObject.name == "RedFish2(Clone)"))
        {
            Destroy(col.gameObject);
        }
    }

	// Update is called once per frame
	void Update () {

	
	}
}
