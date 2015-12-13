using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HookCollisions : MonoBehaviour {

	public AudioClip fishSound;
	public AudioClip junkSound;
	public Text scoreText;
    public Text livesText;
    public Text endScore;
    public GameObject endMenu;
    public GameObject inGameLives;
    public GameObject inGameScore;
    private int lives;
    private bool endOfGame;
	public int fishValue;
	private int score;
    private float newHookY = 3.5F;
    private float speed = 5;
    private float hookStartY = 3.5F;
    private float hookStartX = -2.23F;
    private float prevY;
	AudioSource audio;
	AudioSource audio2;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(hookStartX, hookStartY, 0);
        prevY = hookStartY;
		audio = GetComponent<AudioSource> ();
		audio2 = GetComponent<AudioSource> ();
        lives = 3;
		score = 0;
		scoreText.text = "Score: " + score;
        endOfGame = false;
	}
	
   void OnTriggerEnter2D (Collider2D col)
    {
        //kill fish
        FishMovement isFish = col.gameObject.GetComponent<FishMovement>();
        JunkMovement isJunk = col.gameObject.GetComponent<JunkMovement>();
        if (isFish){
			audio.PlayOneShot(fishSound, 0.7f);
            isFish.killFish();
            addToScore(isFish.getSpeed());
			scoreText.text = "Score: " + score;
             //send hook back to top
            newHookY = hookStartY;
        }     

        if(isJunk){
            audio2.PlayOneShot(junkSound, 2f);
            isJunk.killJunk();
            score -= 5;
            scoreText.text = "Score: " + score;
            lives -= 1;
            livesText.text = "Lives: " + lives;
            if (lives <= 0){
                //go to end screen
                endGame();
            }
            //send hook back to top
            newHookY = hookStartY;
        }  


    }

	// Update is called once per frame
	void Update () {
        //place where user clicks if not end of game
        if ((Input.GetMouseButtonDown(0)) && (endOfGame == false)){ 
            float across = Input.mousePosition.x/Screen.width;
            float up = Input.mousePosition.y/Screen.height;
            if((across > 0.24) && (across < 0.45) && (up < 0.89)){
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

    void addToScore(float speed){
        if ((speed >= 0.01f) && (speed < 0.04f)){
            score += 3;
        }
        if ((speed >=0.04f) && (speed < 0.08f)){
            score += 5;
        }
        if (speed >= 0.08f){
            score += 10;
        }
    }

    public int getLives(){
        return lives;
    }

    void endGame(){
        endMenu.SetActive(true);
        endOfGame = true;
        inGameScore.SetActive(false);
        inGameLives.SetActive(false);
        endScore.text = "YOUR SCORE: " + score;
    }
}
