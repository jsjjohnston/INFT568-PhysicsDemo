using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject groundPrefab;
    public int groundLength;

    public GameObject startWallPrefab;
    public Transform startWallPos;
    public int startWallHeight;
    public int startWallWidth;

    public GameObject endWallPrefab;
    public Transform endWallPos;
    public int endWallHeight;
    public int endWallWidth;

    // Use this for initialization
    void Start () {

        // Generate Ground
        GameObject ga;
        
        for (int x = 0; x < groundLength; x++)
        {
            ga = (GameObject)Instantiate(groundPrefab);
            ga.gameObject.transform.position = new Vector3(x, -1, 0);
            ga.name = "Ground{"+x+",-1}";
            ga.transform.parent = gameObject.transform;
        }

        // Generate End Wall
        for (int x = 0; x < endWallWidth; x++)
        {
            for (int y = 0; y < endWallHeight; y++)
            {
                ga = (GameObject)Instantiate(endWallPrefab);
                ga.transform.position = endWallPos.position + new Vector3(x, y, 0);
                ga.name = "End{" + x + "," + y + "}";
                ga.transform.parent = gameObject.transform;
            }
        }

        // Generate start Wall
        for (int x = 0; x < startWallWidth; x++)
        {
            for (int y = 0; y < startWallHeight; y++)
            {
                ga = (GameObject)Instantiate(startWallPrefab);
                ga.transform.position = startWallPos.position + new Vector3(x, y, 0);
                ga.name = "Start{" + x + "," + y +"}";
                ga.transform.parent = gameObject.transform;

            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
