using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class RigidBodySleep : MonoBehaviour
{
    private Rigidbody rigidBodyBall;

    private void Start()
    {
        rigidBodyBall = GetComponent<Rigidbody>();
        rigidBodyBall.Sleep();
    }
}
