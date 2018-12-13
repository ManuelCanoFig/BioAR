using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset_Scroll : MonoBehaviour {
	GameObject scroll;
	Scrollbar s;

	void Start () {
		s = GameObject.Find ("Scrollbar").GetComponent<Scrollbar>();
		s.value = 1;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
