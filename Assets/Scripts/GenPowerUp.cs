using UnityEngine;

/*
 * Author: Jay Johnston
 * Description: Genarate power up on trigger
 */
public class GenPowerUp : MonoBehaviour {

	public GameObject pickup; // Prefab of pickup
	public Transform location; // Location to setup the Pickup
	private GameObject gPickup; // Handle to Genarated Pickup

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// When Triggered
	private void OnTriggerEnter(Collider other)
	{
		// If Genarated Pickup doesnt exist
		if (gPickup == null)
		{
			gPickup = Instantiate(pickup); // Create it
			gPickup.transform.position = location.position; // Set it's position
		}
	}
}
