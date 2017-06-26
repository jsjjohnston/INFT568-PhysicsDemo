using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBox : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		RaycastHit hit;

		if (Physics.Raycast(transform.position, Vector3.down, out hit))
		{
			if (hit.collider.gameObject.tag == "Player")
			{
				rb.isKinematic = false;
			}
		}
	}
}
