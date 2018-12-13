using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Camera_FocusMode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
