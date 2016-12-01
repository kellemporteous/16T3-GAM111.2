using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class UI_Manager : MonoBehaviour {

    public EventSystem levelEventSystem;
    private Tile_Attach react;

	// Use this for initialization
	void Start ()
    {
        react = GetComponent<Tile_Attach>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ReactToTiles();

    }

    void ReactToTiles()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit HitResults;
            if (Physics.Raycast(ray, out HitResults))
            {
                GameObject HitObject = HitResults.collider.gameObject;

                react = HitObject.GetComponent<Tile_Attach>();
                if (react != null)
                {
                    react.ReactToMouseClick();
                }
            }
        }
    }
}
