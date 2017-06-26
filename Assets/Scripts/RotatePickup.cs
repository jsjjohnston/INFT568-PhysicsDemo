using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatePickup : MonoBehaviour
{
	public static int score = 0;
	private GameObject scoreText;

	// Use this for initialization
	void Start()
	{
		scoreText = GameObject.FindWithTag("ScoreText");
	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		scoreText.GetComponent<Text>().text = "Score: " + ++score;
		Destroy(gameObject); 
	}
}
