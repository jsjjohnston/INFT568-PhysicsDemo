using UnityEngine;

/*
 * Author: Jay Johnston
 * Description: On collision Makes the PLayer Push up
 */
public class PushBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// On collision Push up player
	private void OnTriggerEnter(Collider other)
	{
		other.gameObject.GetComponent<PlayerController>().push();
	}
}
