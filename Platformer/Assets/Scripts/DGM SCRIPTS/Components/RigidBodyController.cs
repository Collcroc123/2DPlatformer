using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class RigidBodyController : MonoBehaviour
{
    private Rigidbody rigidBodyObj;
    public float force = 100;
    private Vector3 forceVector;

    private void Start()
    {
        rigidBodyObj = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        forceVector.y = force;
        rigidBodyObj.AddForce(forceVector);
    }

}
