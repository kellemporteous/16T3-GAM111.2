using UnityEngine;
using System.Collections;

public class Tile_Manager : MonoBehaviour {


    public GameObject tile;
    private UI_Manager UIManager;
    public Sprite[] tileSprite;
    private bool worker = false;
    

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
                MakeTileAt(new Vector2(-23.5f + (i * 1), -25.5f + (j * 1)));
                //Instantiate(tile, new Vector2(-23.5f + (i * 1), -25.5f + (j * 1)), Quaternion.identity);
            }
        }

        for (int i = 0; i < 52; i++)
        {
            for (int j = 0; j < 48; j++)
            {
                MakeTileAt(new Vector2(-25.5f + (i * 1), -23.5f + (j * 1)));
                //Instantiate(tile, new Vector2(-25.5f + (i * 1), -23.5f + (j * 1)), Quaternion.identity);
            }
        }

        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                MakeTileAt(new Vector2(-25.5f + (i * 1), 24.5f + (j * 1)));
            }
        }
    }

    void MakeTileAt(Vector3 pos)
    {
        GameObject newGO = Instantiate(tile, pos, Quaternion.identity) as GameObject;
        newGO.GetComponent<SpriteRenderer>().sprite = tileSprite[Random.Range(0, tileSprite.Length)];
    }

    public void ReactToTile()
    {
        if (worker == true)
        {

        }
        else if(worker == false)
        {
            Debug.Log("Object Clicked!");
        }
    }

    public void ReactToBase()
    {

    }
}
