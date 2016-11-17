using UnityEngine;
using System.Collections;

public class Tile_Spawner : MonoBehaviour {

    public GameObject[] tiles;
    public GameObject tile;

    // Use this for initialization
    void Start ()
    {
        tile = tiles[Random.Range(0, tiles.Length)];
        RandomMap();
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
}
