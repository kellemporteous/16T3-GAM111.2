using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Random_Tile : MonoBehaviour {

    public GameObject[] tileTexture;
    public GameObject tileChosen;
	// Use this for initialization
	void Start ()
    {
        tileChosen = tileTexture[Random.Range(0, tileTexture.Length)];
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
