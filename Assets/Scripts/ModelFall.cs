using UnityEngine;
/*
 * Author: Jay Johnston
 * Description: Enables Disabled Ragdoll Model  to Fall on the player
 */
public class ModelFall : MonoBehaviour {

	public GameObject model; // Ragdoll Model to Enable

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// On Trigger Enable Fall Model
	void OnTriggerEnter(Collider other)
	{
		model.SetActive(true);
	}
}
