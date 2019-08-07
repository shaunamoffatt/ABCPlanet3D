using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraAnimator : MonoBehaviour
{
    private Vector3 position;
    private Animator anim;
    
    GameManager GM;
    GameState animatorState;
    // Start is called before the first frame update

    void Awake()
    {
        GM = GameManager.Instance;
        GM.OnStateChange += HandleOnStateChange;
    }

    public void HandleOnStateChange()
    {
        Debug.Log("CamerAnimator on state change!");
    }


    void Start()
    {

        GM.SetGameState(GameState.MAIN);
        animatorState = GameState.MAIN;
        anim = GetComponent<Animator>();

    }



    void Update()
    {
       

        if (GM.gameState == GameState.SUN && animatorState != GM.gameState)
        {

            animatorState = GameState.SUN;
            Debug.Log(GM.gameState.ToString());
            anim.SetTrigger("SunClick");
        }
        if (GM.gameState == GameState.MAIN && animatorState != GM.gameState)
        {
            animatorState = GameState.MAIN;
            anim.SetTrigger("SunExit");
            
        }


    }

}


