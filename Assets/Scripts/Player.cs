using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Controler2D))]

public class Player : MonoBehaviour {

	Controler2D controller;


	// Use this for initialization
	void Start () {
		controller = GetComponent <Controler2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
