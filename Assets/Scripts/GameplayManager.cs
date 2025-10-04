using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class GameplayManager : MonoBehaviour
{
    private ControllerManager controllerManager;

    void Start()
    {
        controllerManager = ControllerManager.instance;
    }

    void Update()
    {
        if( controllerManager.buttonA.WasPressedThisFrame() ) //Release the button A to select unit and set push power ("release" to avoid input issue just after the selection)
        {
            print( "Validate Button as been pressed" );
        }
    }
}
