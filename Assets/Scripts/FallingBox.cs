using UnityEngine;

/*
 * Author: Jay Johnston
 * Description: Uses Ray Casts to make the box fall on to the player
 */
public class FallingBox : MonoBehaviour {

	private Rigidbody rb; // Handle for Objects Ridgid body

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>(); // Get Rigidbody (should be Kinematic)
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Update for Physics 
	void FixedUpdate()
	{
		RaycastHit hit; // Object Hit with Ray cast

		// Raycast Down
		if (Physics.Raycast(transform.position, Vector3.down, out hit))
		{
			// If Player is hit
			if (hit.collider.gameObject.tag == "Player")
			{
				// Disable Kinematic and enable Physics
				rb.isKinematic = false;
			}
		}
	}
}
