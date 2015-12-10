using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HookCollisions : MonoBehaviour {

	public AudioClip fishSound;
	public Text scoreText;
	public int fishValue;
	private int score;
    private float newHookY = 3.5F;
    private float speed = 5;
    private float hookStartY = 3.5F;
    private float hookStartX = -2.23F;
    //private BoxCollider2D boxCol = gameObject.GetComponent<BoxCollider2D>();
    private float prevY;
	AudioSource audio;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(hookStartX, hookStartY, 0);
        prevY = hookStartY;
		score = 0; 
		scoreText.text = "Score: " + score;
		audio = GetComponent<AudioSource> ();
	}
	
   void OnTriggerEnter2D (Collider2D col)
    {
        //kill fish
        FishCaught isFish = col.gameObject.GetComponent<FishCaught>();
        if (isFish){
			audio.PlayOneShot(fishSound, 0.7f);
            isFish.killFish();
			score += fishValue;
			scoreText.text = "Score: " + score;
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
        //place where user clicks
        if (Input.GetMouseButtonDown(0)){ 
            float across = Input.mousePosition.x/Screen.width;
            float up = Input.mousePosition.y/Screen.height;
            if((across > 0.31) && (across < 0.37) && (up < 0.89)){
                newHookY = 9.928F*up - 4.46F;
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
