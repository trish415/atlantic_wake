using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour {

    private LineRenderer lineRenderer;
    public Transform lineSpot;
	// Use this for initialization
	void Start () {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = true;
        //lineRenderer.useWorldSpace = true;
	}
	
 	// Update is called once per frame
	void Update () {
	   //RaycastHit2D hit = Physics2D.Raycast(transform.position, - transform.up);
       //Debug.DrawLine(transform.position, lineSpot.position);
       //lineSpot.position = hit.point;
       //transform.position.translate(0,0,1);
       //lineSpot.position.translate(0,0,1);
       lineRenderer.SetPosition(0, transform.position);
       lineRenderer.SetPosition(1, lineSpot.position);
       lineRenderer.sortingLayerID = SortingLayer.NameToID("line");

    }
}
