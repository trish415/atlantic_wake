using UnityEngine;
using System.Collections;

public class HookCollisions : MonoBehaviour {

    private float newHookY = 3.5F;
    private float speed = 5;
    private float hookStartY = 3.5F;
    private float hookStartX = -2.23F;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(hookStartX, hookStartY, 0);
	}
	
   void OnTriggerEnter2D (Collider2D col)
    {
        //kill fish
        FishCaught isFish = col.gameObject.GetComponent<FishCaught>();
        if (isFish){
            isFish.killFish();
            //send hook back to top
            newHookY = hookStartY;
            //transform.position = new Vector3(transform.position.x, 3.75F, transform.position.z);
        }
        //add to score
        

    }
    //function to get new height on mousedown
    void OnMouseDown(){

    }
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)){
            print(Input.mousePosition.y);
            if ((Input.mousePosition.x > 190F) && (Input.mousePosition.x < 250F)){
                newHookY = 0.0197F*Input.mousePosition.y -4.5F;
            }
        }
        float step = speed*Time.deltaTime;
        transform.position = Vector2.Lerp(transform.position, new Vector3(transform.position.x, newHookY, transform.position.z), step);
	
	}
}
