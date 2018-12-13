using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class close_videoPanel : MonoBehaviour {
	public GameObject panel;

	void Start () {
	}

	void Update () {
		
	}

	public void onClick(){
		panel.gameObject.SetActive(false);
	}
}
