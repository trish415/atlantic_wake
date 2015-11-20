using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject fish;
    private BoxCollider2D c;
    public Camera cam;
    void Start () {
        if (cam == null) {
            cam = Camera.main;
        }
        StartCoroutine( Spawn());
    }
    
    IEnumerator Spawn() {
        yield return new WaitForSeconds (2.0f);
        while (true) {
            Vector3 spawnPosition = new Vector3 (8, Random.Range (-4, 1), 0.0f);
            Quaternion spawnRotation = Quaternion.identity;    

            Instantiate (fish, spawnPosition, spawnRotation);
            yield return new WaitForSeconds (Random.Range(1.0f, 2.0f));    
        }
    }
}