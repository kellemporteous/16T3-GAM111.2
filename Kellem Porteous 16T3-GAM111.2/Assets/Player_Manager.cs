using UnityEngine;
using System.Collections;

public class Player_Manager : MonoBehaviour {


    public bool player1 = true;
    public bool player2 = false;


    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Player1Turn()
    {

        Camera.main.transform.position = new Vector3(-25, -25, -25);
    }

    public void Player2Turn()
    {

        Camera.main.transform.position = new Vector3(25, 25, -25);

    }
}
