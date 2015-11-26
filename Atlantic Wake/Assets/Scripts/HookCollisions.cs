using UnityEngine;
using System.Collections;

public class HookCollisions : MonoBehaviour {

    private float newHookY = 3.5F;
    private float speed = 5;
    private float hookStartY = 3.5F;
    private float hookStartX = -2.23F;
    //private BoxCollider2D boxCol = gameObject.GetComponent<BoxCollider2D>();
    private float prevY;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(hookStartX, hookStartY, 0);
        prevY = hookStartY;
	}
	
   void OnTriggerEnter2D (Collider2D col)
    {
        //kill fish
        FishCaught isFish = col.gameObject.GetComponent<FishCaught>();
        if (isFish){
            isFish.killFish();
            //send hook back to top
            newHookY = hookStartY;
        }
        //add to score
        

    }
    //function to get new height on mousedown
    void OnMouseDown(){

    }
	// Update is called once per frame
	void Update () {
        //if hook has been reeled in, place where user clicks
        if ((Input.GetMouseButtonDown(0)) && ((transform.position.y - hookStartY) > -0.1)){
            print(Input.mousePosition.y);
            if ((Input.mousePosition.x > 190F) && (Input.mousePosition.x < 250F)){
                newHookY = 0.0197F*Input.mousePosition.y -4.5F;
            }
        }
        
        //if hook is moving, turn box collider off 
        if (((prevY - transform.position.y) < 0.01) && ((prevY - transform.position.y) > -0.01)){
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
        else{
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }

        //update prevY and change position of hook
        prevY = transform.position.y;
        float step = speed*Time.deltaTime;
        transform.position = Vector2.Lerp(transform.position, new Vector3(transform.position.x, newHookY, transform.position.z), step);

	}
}
