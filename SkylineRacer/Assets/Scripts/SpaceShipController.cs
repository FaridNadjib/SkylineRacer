using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpaceShipController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject laserGun;
    private PlayerInputActions inputActions;

    // Input-values
    private float speed;
    private float acceleration;
    private Vector2 rotation;
    private float roll;
    private float up;

    // Adjustments
    [SerializeField] private float accelerationSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float rollSpeed;
    [SerializeField] private float moveUpDownSpeed;

    private void Awake() 
    {
        inputActions = new PlayerInputActions();
        inputActions.Ship.Accelerate.performed += ctx => acceleration = ctx.ReadValue<float>(); //value between -1 and 1
        inputActions.Ship.Rotate.performed += ctx => rotation = ctx.ReadValue<Vector2>();
        inputActions.Ship.Roll.performed += ctx => roll = ctx.ReadValue<float>();
        inputActions.Ship.MoveUp.performed += ctx => up = ctx.ReadValue<float>();
        inputActions.Ship.ShootLaser.performed += ctx => OnShootLaser();
    }

    private void Update() 
    {
        Debug.Log(acceleration);
        transform.Rotate(new Vector3(rotation.y * rotationSpeed, rotation.x * rotationSpeed, roll * rollSpeed) * Time.deltaTime, Space.Self);
    }

    private void FixedUpdate() 
    {        
        Accelerate();

        //create direction vector with the calculated speed
        Vector3 direction = new Vector3(0, up * moveUpDownSpeed, speed) * Time.fixedDeltaTime;
        //transform direction to worldspace
        direction = transform.TransformDirection(direction);
        //apply velocity
        rb.velocity = direction;    
    }

    private void Accelerate()
    {
        rb.AddForce(transform.forward * acceleration * 1000 * accelerationSpeed * Time.fixedDeltaTime);
        //speed += acceleration * accelerationSpeed;
    }

    private void OnShootLaser()
    {
        Debug.DrawRay(laserGun.transform.position, Vector3.forward, Color.red, 50f);
    }

    private void OnEnable() 
    {
        inputActions.Enable();
    }

    private void OnDisable() 
    {
        inputActions.Disable();
    }
}
