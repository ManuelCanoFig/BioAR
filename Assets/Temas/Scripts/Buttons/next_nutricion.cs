using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using UnityEngine.U2D;

public class next_nutricion : MonoBehaviour {
	public Sprite nutricion1, nutricion2, nutricion3, nutricion4, nutricion5, nutricion6, nutricion7, nutricion8, nutricion9, nutricion10, nutricion11, nutricion12;
	public SpriteRenderer nutricion_frame, sexualidad_frame;
	public int i;

	void Start () {
		CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		nutricion_frame = GameObject.Find("Nutricion_frame").GetComponent<SpriteRenderer> ();
		i = 0;
	}

	void Update () {
		
	}

	public void onClick(){
			i = i + 1;
			if (i > 12) {
				i = 0;
			}
			cambiarFoto (i);
	}

	public void atras(){
		i = i - 1;
		if (i < 0) {
			i = 12;
		}
		cambiarFoto (i);
	}

	public void cambiarFoto(int i){
		if (i == 0) {
			nutricion_frame.sprite = nutricion1;
			Debug.Log ("imagen0");
		}
		if (i == 1) {
			nutricion_frame.sprite = nutricion2;
			Debug.Log ("imagen1");
		}
		if (i == 2) {
			nutricion_frame.sprite = nutricion3;
			Debug.Log ("imagen2");
		}

		if (i == 3) {
			nutricion_frame.sprite = nutricion4;
			Debug.Log ("imagen3");
		}

		if (i == 4) {
			nutricion_frame.sprite = nutricion5;
			Debug.Log ("imagen4");
		}

		if (i == 5) {
			nutricion_frame.sprite = nutricion6;
			Debug.Log ("imagen5");
		}

		if (i == 6) {
			nutricion_frame.sprite = nutricion7;
			Debug.Log ("imagen6");
		}

		if (i == 7) {
			nutricion_frame.sprite = nutricion8;
			Debug.Log ("imagen7");
		}

		if (i == 8) {
			nutricion_frame.sprite = nutricion9;
			Debug.Log ("imagen8");
		}

		if (i == 9) {
			nutricion_frame.sprite = nutricion10;
			Debug.Log ("imagen9");
		}

		if (i == 10) {
			nutricion_frame.sprite = nutricion11;
			Debug.Log ("imagen10");
		}

		if (i == 11) {
			nutricion_frame.sprite = nutricion12;
			Debug.Log ("imagen11");
		}
	}
}
