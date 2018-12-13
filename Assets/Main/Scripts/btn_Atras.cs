using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class btn_Atras : MonoBehaviour {

	void Start () {
		
	}

	void Update () {

	}

	public void onClick() {
		SceneManager.LoadScene ("Main_Menu");
	}
}
