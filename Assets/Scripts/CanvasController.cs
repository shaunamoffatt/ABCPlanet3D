using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        //TODO better manager needed and delay
        if (GameManager.Instance.gameState == GameState.MAIN)
        {
            GameObject.Find("SunUI").transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            GameObject.Find("SunUI").transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void PressExit()
    {
        GM.SetGameState(GameState.MAIN);
    }
}



