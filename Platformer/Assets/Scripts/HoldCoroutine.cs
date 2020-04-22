using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HoldCoroutine : MonoBehaviour
{
    public float holdTime = 1f;
    private WaitForSeconds waitObj;
    public UnityEvent holdEvent;

    void Start()
    {
        waitObj = new WaitForSeconds(holdTime);
    }

    public void StartCo()
    {
        StartCoroutine(Run());
    }

    public IEnumerator Run()
    {
        yield return waitObj;
        holdEvent.Invoke();
    }
}
