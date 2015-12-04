using UnityEngine;
using System.Collections;

public class WaveGenerate : MonoBehaviour {
    public GameObject wave;

    void OnTriggerEnter2D (Collider2D other) {
        StartCoroutine(WaveSpawn());
        Destroy (other.gameObject);
    }

    IEnumerator WaveSpawn(){
        Quaternion spawnRotation = Quaternion.identity;
        Vector3 waveStart = new Vector3(-11.42f, 2.5f, 0.0f);
        Instantiate (wave, waveStart, spawnRotation);
        yield return new WaitForSeconds(0.0f);
    }
}
