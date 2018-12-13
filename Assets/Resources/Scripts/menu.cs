using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour {
	public GameObject despliega;
	public Text Titulo, Cuerpo;
	public Button menu1;
	public Button texto1;
	public Button texto2;
	bool activo = false;



	// Use this for initialization
	void Start () {
		despliega = GameObject.Find ("Menu1");
		despliega.gameObject.SetActive (false);

		Titulo = GameObject.Find ("Text_titulo").GetComponent<Text>();
		Cuerpo = GameObject.Find ("Cuerpo").GetComponent<Text>();


		//menu1.onClick.AddListener (ocultar);
		//texto1.onClick.AddListener (cambiarinfo);
		//texto2.onClick.AddListener (cambiarinfo1);
		//cambiarinfo ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ocultar()
	{
		if (activo == false) {
			despliega.gameObject.SetActive (true);
			activo = true;
		} else {
			despliega.gameObject.SetActive (false);
			activo = false;
		}
 	}

	public void cambiarinfo(){
		Titulo.fontSize = 32;
		Titulo.text = "¿Qué es la nutrición?";
		Cuerpo.text = "La nutrición es el concepto que hace referencia al proceso mediante el que el organismo asimila los nutrientes\nde los alimentos,  a través de una serie de fenómenos espontáneos, como la digestión, la absorción de los nutrientes\na la sangre a través del tubo digestivo y la asimilación de los mismos por células del organismo. Y es por ello, que \ngracias a estos fenómenos llevados a cabo por la nutrición, , se toma la energía necesaria para poder llevar a cabo\nel resto de las funciones vitales, además para desempeñar las actividades cotidianas.";
		ocultar ();
	}

	public void cambiarinfo1(){
		Titulo.fontSize = 25;
		Titulo.text = "¿Por qué prestar atención a la nutrición?";
		Cuerpo.text = "La importancia de la nutrición para el buen funcionamiento del organismo radica fundamentalmente en que los habitos\nalimenticios sean adecuados. Si bien parece simple corregir malos hábitos, la realidad nos muestra que es mucho más complicado\nde lo que parece y que las enfermedades relacionadas con la nutrición son hoy en día una preocupación mundial. La nutrición es salud. El consumo diario de estos nutrientes, así como llevar a cabo hábitos saludables, como la \npráctica de actividad fisica de forma regular, son unos de los pilares de la buena salud y el desarrollo físico y mental. \nEs por ello que la nutrición contribuye de manera directa para reforzar el sistema inmune, contraer menos enfermedades y\nen definitiva, tener buena salud. ";
		ocultar ();
	}

}
