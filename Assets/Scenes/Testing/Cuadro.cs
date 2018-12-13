using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cuadro : MonoBehaviour {


	public Text title, desc;
	private string marcador;

	void Start () {
		

	}

	public void OnGUI(){
		title = GameObject.Find("Titulo").GetComponent<Text> ();
		title.text = "Cubo";
	}

	void Update () {

	}
}
