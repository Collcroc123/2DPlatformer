using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoBehaviours : MonoBehaviour
{
    public UnityEvent startEvent;

    // Start is called before the first frame update
    void Start()
    {
        startEvent.Invoke();
    }
}
