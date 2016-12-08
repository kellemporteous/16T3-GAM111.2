using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour {

    public Image profile;
    public EventSystem levelEventSystem;
    public Renderer rend;
    private Tile_Manager tileManager;
    private Player_Manager playerManager;


    public GameObject redBaseUI;

	// Use this for initialization
	void Start ()
    {
        playerManager = GameObject.FindGameObjectWithTag("Player Manager").GetComponent<Player_Manager>();

        tileManager = GameObject.FindGameObjectWithTag("Tile Manager").GetComponent<Tile_Manager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ReactToMouseClick();

    }

    void ActiveButtons()
    {
        switch (tag)
        {
            case "Red Base":
                redBaseUI.SetActive(true);
                break;
            
        }
    }

    void ReactToMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit HitResults;

            if (Physics.Raycast(ray, out HitResults))
            {
                if (HitResults.collider.tag == "Tile")
                {
                    tileManager.ReactToTile();
                }

                if (HitResults.collider.tag == "Red Base")
                {
                    tileManager.ReactToBase();
                }
            }
        }
    }
}
