using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    private void ChangePosition(Vector3 direction)
    {
        transform.Rotate(new Vector3(direction.magnitude, 0f, 0f));
        //Debug.Log($"rotate {gameObject.name} speed {direction}");
    }
}
