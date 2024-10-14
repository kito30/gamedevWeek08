using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerControl playerControl;
    private InputAction movementAction;
    [SerializeField] private float speed;
    private enum playerSelection
    {
        player1,
        player2
    }
    [SerializeField] private playerSelection player;
    void Awake()
    {
        playerControl = new PlayerControl();
        if(player == playerSelection.player1)
        {
            movementAction = playerControl.Movement.movement;
        }
        else
        {
            movementAction = playerControl.Movement.movement2;
        }
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
