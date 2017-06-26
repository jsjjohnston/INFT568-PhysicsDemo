using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenPowerUp : MonoBehaviour {

	public GameObject pickup;
	public Transform location;

	GameObject ga;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (ga == null)
		{
			ga = Instantiate(pickup);
			ga.transform.position = location.position;
		}
	}
}
