using UnityEngine;
/*
 * Author: Jay Johnston
 * Description: Handles players movment
 */
public class PlayerController : MonoBehaviour
{
    public float speed; // How Fast to Apply Force
    private Rigidbody rb; // Handle to Rigidbody 

	void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get Instance of Rigidbody
	}

    void FixedUpdate()
    {
		float moveHorizontal = Input.GetAxis("Horizontal"); // Get Amount to move Player Horizontal

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0); // Create Movment Vector

		// If player is within Threshold press Jump
        if (Input.GetKeyDown("space") && gameObject.transform.position.y < 4.5f)
        {
            rb.AddForce(0,6,0, ForceMode.Impulse); // Apply Jump Force
        }

        rb.AddForce(movement * speed, ForceMode.Acceleration); // Apply Movment Force
    }

	// Pushup player (used by Certin triggers)
	public void push()
	{
		rb.AddForce(0, 10, 0, ForceMode.Impulse);
	}
 }