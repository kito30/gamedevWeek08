using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerControl playerControl;
    private InputAction movementAction;
    [SerializeField] private float speed;
    void Awake()
    {
        playerControl = new PlayerControl();
        movementAction = playerControl.Movement.movement;
    }
    void OnEnable()
    {
        movementAction.Enable();
    }
    void OnDisable()
    {
        movementAction.Disable();
    }
    void Update()
    {
        Vector2 input = movementAction.ReadValue<Vector2>();
        transform.Translate(input.x * speed * Time.deltaTime, 0, input.y * speed* Time.deltaTime);
    }
}
