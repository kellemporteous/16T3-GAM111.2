using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour {

    public Image profile;
    public EventSystem levelEventSystem;
    public Renderer rend;
    private Tile_Manager react;

    public GameObject redBaseUI;

	// Use this for initialization
	void Start ()
    {
        react = GetComponent<Tile_Manager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ReactToTiles();

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

    void ReactToTiles()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit HitResults;

            if (Physics.Raycast(ray, out HitResults))
            {
                if (HitResults.collider.tag == "Tile")
                {
                    Debug.Log("Clicked!");
                }
            }
        }
    }
}
