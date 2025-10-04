using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Android;

public class GameplayManager : MonoBehaviour
{
    private ControllerManager controllerManager;
    public bool isInContractMode = true;

    [Header( "RotatableObject" )]
    public GameObject currentRotatableObject = null;
    public List<GameObject> entireRotatableObjectsList = new List<GameObject>();
    public List<GameObject> dailyRotatableObjectsList = new List<GameObject>();
    public List<GameObject> validetdObjectsList = new List<GameObject>();
    public Transform RotatableObjectPivot = null;
    public float rotationSpeed = 1.0f;

    void Start()
    {
        controllerManager = ControllerManager.instance;
    }

    void Update()
    {
        if( controllerManager.buttonA.WasPressedThisFrame() ) //Release the button A to select unit and set push power ("release" to avoid input issue just after the selection)
        {
            print( "Validate Button as been pressed" );
            if( isInContractMode )
            {
                isInContractMode = false;
            }
        }
       
        if( controllerManager.rightStick.ReadValue<Vector2>().x != 0 || controllerManager.rightStick.ReadValue<Vector2>().y != 0 ) //Release the button A to select unit and set push power ("release" to avoid input issue just after the selection)
        {
            RotateObject();
        }
    }

    private void PickObjectsFromList()
    {

    }

    private void RotateObject()
    {
        Vector3 rotationVector = new Vector3( controllerManager.rightStick.ReadValue<Vector2>().y, -controllerManager.rightStick.ReadValue<Vector2>().x, 0.0f );
        RotatableObjectPivot.RotateAround( RotatableObjectPivot.position, rotationVector, rotationSpeed * Time.deltaTime );
    }

    private void ValidateContract()
    {
        
    }

    private void ValidateObject()
    {
        validetdObjectsList.Add( currentRotatableObject );
    }

    private void MoveToPreviousObject()
    {
       // dailyRotatableObjectsList
    }

    private void MoveToNextObject()
    {

    }

    private void RotateCameraToObjects()
    {

    }

    private void RotateCameraToDesk()
    {

    }
}
