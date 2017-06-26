using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelFall : MonoBehaviour {

	public GameObject model;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		model.SetActive(true);
	}
}
