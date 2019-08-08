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
        //if the gamestate has changed but not updated the cameraAnimator..
        //...animator state. Time to animate.
        //if(GM.previousState != null)
        if (GM.gameState != animatorState)
        {
            Debug.Log("Change animation");
            ChangeAnimation();
        }
    }

    /// <summary>
    /// Animation Triggers on the camera are named so that it show what transition state has just happened
    /// For eg. if going from the main view to sun view the trigger is named "mainsun"
    /// going from the sun view to the main is named "sunmain" etc.
    /// </summary>
    private void ChangeAnimation()
    {
        animatorState = GM.gameState;
        Debug.Log(GM.previousState.ToString().ToLower() + GM.gameState.ToString().ToLower());
        anim.SetTrigger(GM.previousState.ToString().ToLower() + GM.gameState.ToString().ToLower());
    }
}


