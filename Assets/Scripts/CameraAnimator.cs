using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraAnimator : MonoBehaviour
{
    private Animator anim;
    private GameManager GM;

    // Start is called before the first frame update

    void Awake()
    {
        GM = GameManager.Instance;
        GM.OnStateChange += HandleOnStateChange;
    }

    public void HandleOnStateChange()
    {
        Debug.Log("CamerAnimator on state change!");
        if(GM.previousState != GM.gameState)
            ChangeAnimation();
    }


    void Start()
    {
        GM.SetGameState(GameState.MAIN);
        anim = GetComponent<Animator>();

    }
    
    /// <summary>
    /// Animation Triggers on the camera are named so that it show what transition state has just happened
    /// For eg. if going from the main view to sun view the trigger is named "mainsun"
    /// going from the sun view to the main is named "sunmain" etc.
    /// </summary>
    public void ChangeAnimation()
    {
        //TODO delete
        Debug.Log(GM.previousState.ToString().ToLower() + GM.gameState.ToString().ToLower());
        anim.SetTrigger(GM.previousState.ToString().ToLower() + GM.gameState.ToString().ToLower());
    }
}


