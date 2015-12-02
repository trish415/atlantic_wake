using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject RedFish;
	public GameObject YellowFish;
	public GameObject PinkFish;
	public GameObject PurpleFish;
	public GameObject GreenFish;  
	public GameObject BlackFish;
	private BoxCollider2D c;
    public Camera cam;
	public float timeLeft;
	public Text timerText;
    void Start () {
        if (cam == null) {
            cam = Camera.main;
        }
        StartCoroutine( Spawn());
		timerText.text = "Time Left:\n" + Mathf.RoundToInt (timeLeft);
    }

	void FixedUpdate() {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			timeLeft = 0;
		}
		timerText.text = "Time Left:\n" + Mathf.RoundToInt (timeLeft);
	}
    
    IEnumerator Spawn() {
        yield return new WaitForSeconds (2.0f);
        while (timeLeft > 0) {
            Vector3 spawnPosition = new Vector3 (8, Random.Range (-4, 1), 0.0f);
            Quaternion spawnRotation = Quaternion.identity;    
			float chooseFish = Random.Range(0,10);
			if (chooseFish >= 0 && chooseFish < 2) {
            	Instantiate (RedFish, spawnPosition, spawnRotation);
			}
			if (chooseFish >= 2 && chooseFish < 4) {
				Instantiate (GreenFish, spawnPosition, spawnRotation);
			}
			if (chooseFish >= 4 && chooseFish < 6) {
				Instantiate (PurpleFish, spawnPosition, spawnRotation);
			}
			if (chooseFish >= 6 && chooseFish < 8) {
				Instantiate (BlackFish, spawnPosition, spawnRotation);
			}
			if (chooseFish >= 8 && chooseFish < 9.5) {
				Instantiate (PinkFish, spawnPosition, spawnRotation);
			}
			if (chooseFish >= 9.5 && chooseFish <= 10) {
				Instantiate (YellowFish, spawnPosition, spawnRotation);
			}
			yield return new WaitForSeconds (Random.Range(1.0f, 2.0f));    
        }
    }
}