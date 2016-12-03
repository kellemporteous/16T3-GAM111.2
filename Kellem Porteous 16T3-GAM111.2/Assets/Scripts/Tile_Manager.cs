using UnityEngine;
using System.Collections;

public class Tile_Manager : MonoBehaviour {
    public GameObject tile;
    private UI_Manager UIManager;

    // Use this for initialization
    void Start()
    {
        RandomMap();

        UIManager = GetComponent<UI_Manager>();
    }

    void RandomMap()
    {
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Instantiate(tile, new Vector2(-23.5f + (i * 1), -25.5f + (j * 1)), Quaternion.identity);
            }
        }

        for (int i = 0; i < 52; i++)
        {
            for (int j = 0; j < 48; j++)
            {
                Instantiate(tile, new Vector2(-25.5f + (i * 1), -23.5f + (j * 1)), Quaternion.identity);
            }
        }

        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Instantiate(tile, new Vector2(-25.5f + (i * 1), 24.5f + (j * 1)), Quaternion.identity);
            }
        }
    }

    public void ReactToMouseClick()
    {

        Debug.Log("Object Clicked!");
    }
}

