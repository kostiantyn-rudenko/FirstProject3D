using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Update()
    {
        //Debug.Log(Input.GetAxis("Horizontal"));
        transform.Translate(new Vector3(-Input.GetAxis("Horizontal"), 0f, -Input.GetAxis("Vertical")));
    }
}
