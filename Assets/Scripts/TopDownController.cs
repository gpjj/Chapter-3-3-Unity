using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector3> OnMoveEvent;

    public void CallMoveEvent(Vector3 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }
}
