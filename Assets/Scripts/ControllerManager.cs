using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class ControllerManager : MonoBehaviour
{
    public InputSystem_Actions inputs = null;

    [HideInInspector] public InputAction LeftStick;
    [HideInInspector] public InputAction rightStick;
    [HideInInspector] public InputAction buttonA;
    [HideInInspector] public InputAction buttonB;

    public static ControllerManager instance;

    void Awake()
    {
        instance = this;
        inputs = new InputSystem_Actions();
    }

    void OnEnable()
    {
        LeftStick = inputs.Player.Move;
        LeftStick.Enable();

        rightStick = inputs.Player.Look;
        rightStick.Enable();

        buttonA = inputs.Player.Validate;
        buttonA.Enable();
        //buttonA.performed += ButtonA; //I just kept this line to have this specific way of calling an input action

        buttonB = inputs.Player.Cancel;
        buttonB.Enable();
    }

    private void OnDisable()
    {
        LeftStick.Disable();
        rightStick.Disable();
        buttonA.Disable();
        buttonB.Disable();
    }

    //public void ButtonA( InputAction.CallbackContext context )
    //{
    //    print( "We Press A" );
    //}
}

