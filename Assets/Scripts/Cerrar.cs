using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cerrar : MonoBehaviour {

	public Button Salir;
	// Use this for initialization
	void Start () {
		Button btn = Salir.GetComponent<Button>();
		btn.onClick.AddListener(Close);
	}
	
	// Update is called once per frame
	void Update () {
		Application.Quit ();
	}

	void Close (){
		Application.Quit ();
	}
}
