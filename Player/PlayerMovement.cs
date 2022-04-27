using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;

    private Vector3 input;
    private Vector3 velocity;

    [SerializeField] private float walkspeed;

    [SerializeField] private CinemachineVirtualCamera camera;

    public int clickable;

    private void Start()
    {
        Initialize();
    }

    private void FixedUpdate()
    {
        if (controller.isGrounded)
        {
            velocity = Vector3.zero;
            if (input.sqrMagnitude > 0f)
            {
                transform.LookAt(transform.position + input);
                velocity = transform.forward * walkspeed;
            }
        }
        velocity.y += Physics.gravity.y * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        float x = -context.ReadValue<Vector2>().y + -context.ReadValue<Vector2>().x;
        float z = -context.ReadValue<Vector2>().y + context.ReadValue<Vector2>().x;
        input = new Vector3(x, 0f, z);
        if (context.performed)
        {
            Debug.Log(context.ReadValue<Vector2>());
        }
    }

    public void OnSubmit(InputAction.CallbackContext context)
    {
        if (clickable == 1)
        {
            camera.Priority = 1;
        }
    }
    public void OnCancel(InputAction.CallbackContext context)
    {
        if (clickable == 1)
        {
            camera.Priority = 12;
        }
    }

    private void Initialize()
    {
        controller = GetComponent<CharacterController>();
        input = Vector3.zero;
        velocity = Vector3.zero;
        walkspeed = 5f;
        clickable = 0;
    }
}
