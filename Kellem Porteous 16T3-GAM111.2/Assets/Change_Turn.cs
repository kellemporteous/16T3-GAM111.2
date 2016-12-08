using UnityEngine;
using System.Collections;

public class Change_Turn : MonoBehaviour {

    public Tile_Manager tileManager;
    public Player_Manager playerManager;

    // Use this for initialization
    void Start ()
    {
        playerManager = GameObject.FindGameObjectWithTag("Player Manager").GetComponent<Player_Manager>();

        tileManager = GameObject.FindGameObjectWithTag("Tile Manager").GetComponent<Tile_Manager>();
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void ChangeTurn()
    {
        if (playerManager.player1 == true)
        {
            playerManager.player1 = false;
            playerManager.Player2Turn();
            playerManager.player2 = true;
        }

        else if (playerManager.player2 == true)
        {
            playerManager.player1 = true;
            playerManager.Player1Turn();
            playerManager.player2 = false;
        }
    }
}
