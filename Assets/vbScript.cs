using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {
	public GameObject vButtonObject, mundo;
	public 

	void Start () {
		vButtonObject = GameObject.Find ("vb_rotar_mas");
		mundo = GameObject.Find ("Sphere");
		vButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb){
		Debug.Log ("Button Pressed");
		mundo.SetActive (false);
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		Debug.Log ("Button Released");
		mundo.SetActive (true);
	}
}