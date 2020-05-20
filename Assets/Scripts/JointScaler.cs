using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointScaler : MonoBehaviour
{
    [SerializeField] private Transform _object1 = null;
    [SerializeField] private Transform _object2 = null;
    private bool _isValid = false;
    public Vector3 ScaleDirection { get; set; }

    private void Start()
    {
        if (_object1 != null && _object2 != null)
            _isValid = true;
        else
            Debug.Log($"[JointScaler] {gameObject.name} would not work. object1 = {_object1.ToString()}, object2 = {_object2.ToString()}");

        ScaleDirection = Vector3.up;
    }

    private void Update()
    {
        if (!_isValid)
            return;

        Vector3 resVector = _object2.position - _object1.position;
        Vector3 scale = transform.localScale;
        transform.localScale = new Vector3(scale.x, resVector.magnitude, scale.z);
        transform.position = _object2.position - resVector/2;
        //resVector.
        //Debug.Log($"scale = {transform.localScale}. resVect magn = {resVector.magnitude}");
    }
}
