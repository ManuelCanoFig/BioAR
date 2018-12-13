using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuBtn : MonoBehaviour {
	public GameObject menu;
	public Text dNombre, dNombreCi;
	bool isActive = false;


	
	void Start () {
		menu = GameObject.Find("p_menu"); 
		menu.gameObject.SetActive (false); 


	
		dNombre = GameObject.Find("txt-title").GetComponent<Text>();
		dNombreCi = GameObject.Find ("txt-info").GetComponent<Text> ();




		cambiarinfo();

	}

	void Update () {

	}

	public void ocultar(){
		if (isActive == false) {
			menu.gameObject.SetActive (true);
			isActive = true;
		} else {
			menu.gameObject.SetActive (false);
			isActive = false;
		}
	}

	public void cambiarinfo(){
		
		dNombre.text = "Tema1";
		dNombreCi.text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
	}

	public void cambiarinfo1(){

		dNombre.text = "Tema2";
		dNombreCi.text = "Lorem2 ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\ntempor incididunt ut labo2re et dolore magna aliqua. Ut enim 2ad minim v2eniam,\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
	}

	//================================================//
	//Hacer un algoritmo capaz de automatizar el 
	// cabio de la información. Deben de hacerlo de lo contrario el punto extra :D 
	//================================================//

}
