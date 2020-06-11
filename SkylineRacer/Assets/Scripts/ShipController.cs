using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private float speed;
    private float maxSpeed;
    private float minSpeed;
    [SerializeField] private float accelerationSpeed;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private Camera cam;

    private bool accelerate;
    private bool accelerateNegative;


    // Start is called before the first frame update
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        MovementInput();
    }

    private void MovementInput()
    {
        AccelerationInput();
        //YRotationInput();
        ZRotationInput();
        XYRotation();
    }

    private void AccelerationInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            accelerate = true;
        }
        else
        {
            accelerate = false;
        }

        if (Input.GetKey(KeyCode.S) && !accelerate)
        {
            accelerateNegative = true;
        }
        else
        {
            accelerateNegative = false;
        }
    }

    private void YRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, 2 * rotationSpeed * Time.deltaTime, Space.Self);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, -2 * rotationSpeed * Time.deltaTime, Space.Self);
        }
    }

    private void ZRotationInput()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward, 2 * rotationSpeed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.forward, -2 * rotationSpeed * Time.deltaTime, Space.Self);
        }
    }

    private void XYRotation()
    {
        // Vector2 shipScreenPosition = cam.WorldToViewportPoint(transform.position);
        // Vector2 mouseScreenPosition = (Vector2)cam.ScreenToViewportPoint(Input.mousePosition);

        // float angle = Vector2.Dot(shipScreenPosition, mouseScreenPosition);
        // transform.rotation = Quaternion.Euler(new Vector3(angle, angle, angle));

        transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * rotationSpeed * Time.deltaTime, Space.Self);
    }

    private void FixedUpdate()
    {
        Accelerate();

        //create direction vector with the calculated speed
        Vector3 direction = new Vector3(0, 0, speed);
        //transform direction to worldspace
        direction = transform.TransformDirection(direction);
        //apply velocity
        rb.velocity = direction;
    }

    private void Accelerate()
    {
        if (accelerate)
        {
            speed += accelerationSpeed * Time.fixedDeltaTime;
        }
        else if (accelerateNegative)
        {
            speed -= accelerationSpeed * Time.fixedDeltaTime;
        }
    }
}


