using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class boton : MonoBehaviour, IVirtualButtonEventHandler {
	public GameObject vButtonObject;

	void Start () {
		vButtonObject = GameObject.Find ("vb_rotar_mas");
		vButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb){
		Debug.Log ("Button Pressed");
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		Debug.Log ("Button Released");
	}
}
