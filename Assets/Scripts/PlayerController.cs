using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveDistance = 1; // 이동 거리
    private Vector3 curPos; // 현재 플레이어 위치
    private Vector3 moveValue; 
    public float moveTime = 0.4f; // 이동 시간 
    public Transform chick = null;

    void Start()
    {
        moveValue = Vector3.zero;
        curPos = transform.position;
    }

    public void Move(InputAction.CallbackContext context)
    {
        Vector3 input = context.ReadValue<Vector3>();

        if (input.magnitude > 1f) return;

        if (context.performed)
        {
            if (input.magnitude == 0f)
            {
                Moving(transform.position + moveValue);
                Rotate(moveValue);
                moveValue = Vector3.zero;
            }
            else
            {
                moveValue = input * moveDistance;
            }
        }
    }

    void Moving(Vector3 pos)
    {
        LeanTween.move(this.gameObject, pos, moveTime).setOnComplete(() => { if (pos.z > curPos.z) SetMoveForwardState(); });
    }
    void Rotate(Vector3 pos)
    {
        chick.rotation = Quaternion.Euler(270, pos.x * 90, 0);
    }
    void SetMoveForwardState()
    {
        //Manager.instance.UpdateDistanceCount();
        curPos = transform.position;
    }
}
