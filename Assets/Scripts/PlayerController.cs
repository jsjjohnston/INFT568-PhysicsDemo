using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
		float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (Input.GetKeyDown("space") && gameObject.transform.position.y < 4.5f)
        {
            rb.AddForce(0,6,0, ForceMode.Impulse);
        }

        rb.AddForce(movement * speed);
    }

	public void push()
	{
		rb.AddForce(0, 10, 0, ForceMode.Impulse);
	}
 }