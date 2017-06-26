using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
	public static int score = 0; // Current Value of Score
	private GameObject scoreText; // Handel to Score Text

	// Use this for initialization
	void Start()
	{
		scoreText = GameObject.FindWithTag("ScoreText"); // Get instance of Score Text in the UI
	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); // Animate the Pickup
	}

	// On Trigger
	void OnTriggerEnter(Collider other)
	{
		scoreText.GetComponent<Text>().text = "Score: " + ++score; // Update Score
		Destroy(gameObject); // Destroy Pickup
	}
}
