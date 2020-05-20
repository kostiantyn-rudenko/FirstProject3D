using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointDestroyer : MonoBehaviour
{
    [SerializeField] FixedJoint _joint = null;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            var rigitbody = _joint.gameObject.GetComponent<Rigidbody>();
            rigitbody.AddForce(0f, -20f, 0f);
            Destroy(gameObject);
        }
    }
}
