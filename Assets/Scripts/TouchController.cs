using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchController : MonoBehaviour
{
    GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameManager.Instance;
        //if raycaster doesnt exist make one
        this.addPhysicsRaycaster();
    }

    //add physicsRaycaster to camera if it doesnt exist
    private void addPhysicsRaycaster()
    {
        PhysicsRaycaster physicsRaycaster = FindObjectOfType<PhysicsRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<PhysicsRaycaster>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Construct a ray from the current touch coordinates
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Create a particle if hit
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "sun")
                {
                    if (GM.gameState != GameState.SUN)
                        GM.SetGameState(GameState.SUN);
                    Debug.Log("touch controller hit the " + hit.transform.tag);
                }
            }
        }

    }
}
