using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{

    public void OnMove(InputValue value)
    {
        Vector3 moveInput = value.Get<Vector3>().normalized;
        CallMoveEvent(moveInput);
    }

}
