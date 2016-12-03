using UnityEngine;
using System.Collections;

public class Random_Tile : MonoBehaviour {

    public Material[] tileTexture;
    public Renderer rend;
	// Use this for initialization
	void Start ()
    {
        rend = GetComponent<Renderer>();

        rend.material = tileTexture[Random.Range(0, tileTexture.Length)];

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
