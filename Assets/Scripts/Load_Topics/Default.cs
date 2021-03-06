﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
// Script para Cargar Pagina de Bienvenida en Seccion - Camara
public class Default : MonoBehaviour, ITrackableEventHandler {

	private GameObject Canvas, Frame;
	private Text title, desc;
	bool estado = false;
	private TrackableBehaviour mTrackableBehaviour;

	void Start () {
		CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		title = GameObject.Find("Titulo").GetComponent<Text> ();
		desc = GameObject.Find("Descripcion").GetComponent<Text> ();
		Frame = GameObject.Find ("Frame");

		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED)
			{
				estado = true;
			}
			else
			{
				estado = false;
			}
		} 

	public void OnGUI(){
		if (estado == true){
				title.text = "Cubo Detectado";
				Frame.SetActive (false);
				desc.text = "Esto es un cubo";
		}
	}

	void Update (){
		
	}
}