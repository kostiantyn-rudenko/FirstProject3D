using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoover : MonoBehaviour
{
    [SerializeField] Transform _objectToFollow = null;
    private Vector3 _offset;
    void Start()
    {
        _offset = _objectToFollow.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _objectToFollow.position - _offset;
    }
}
