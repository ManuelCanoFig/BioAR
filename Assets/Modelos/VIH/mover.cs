using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
	// Use this for initialization
	public float vuelta =50f;
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, -vuelta * Time.deltaTime);
	}
}
