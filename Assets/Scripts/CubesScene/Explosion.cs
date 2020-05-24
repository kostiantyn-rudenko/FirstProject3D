using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _force = 300f;
    [SerializeField] private float _radius = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ExlposionInner();
        }
    }

    private void ExlposionInner()
    {
        var exploydedObjectArray = Physics.OverlapSphere(transform.position, _radius);
        foreach (var item in exploydedObjectArray)
        {
            var rigidBody = item.GetComponent<Rigidbody>();
            if (rigidBody == null)
                continue;

            rigidBody.AddExplosionForce(_force, transform.position, _radius);
        }
    }
}
