using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    [SerializeField] private float _force = 300f;
    [SerializeField] private float _radius = 10f;
    [SerializeField] GameObject _explodeAnchor = null;
    public void Exlpode()
    {
        var transforms = _explodeAnchor.GetComponentsInChildren<Transform>();
        foreach (var obj in transforms)
        {
            Debug.Log(obj);
            var rigidBody = obj.GetComponent<Rigidbody>();
            if (rigidBody == null)
                continue;
            rigidBody.isKinematic = false;
            rigidBody.AddExplosionForce(_force, _explodeAnchor.transform.position, _radius);
        }
    }
}
