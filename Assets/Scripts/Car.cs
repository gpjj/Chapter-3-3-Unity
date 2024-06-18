using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
   

    public float moveSpeed;
    float move;
    private void Update()
    {
        move = moveSpeed * Time.deltaTime;
        this.transform.Translate(0f, 0f, move);
    }

   
}
