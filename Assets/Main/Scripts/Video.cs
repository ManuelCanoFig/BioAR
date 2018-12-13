using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Video : MonoBehaviour {
	public GameObject panel;

	void Start () {
		panel.gameObject.SetActive (false);
	}

	void Update () {
		
	}

	public void onClick(){
		SceneManager.LoadScene ("video_Biodiversidad");
	}

	public void showPanel(){
		panel.gameObject.SetActive (true);
	}
}
