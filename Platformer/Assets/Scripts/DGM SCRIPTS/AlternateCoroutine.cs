using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternateCoroutine : MonoBehaviour
{
    private WaitForFixedUpdate waitObj;
    public bool canRun = true;

    // Start is called before the first frame update
    void Start()
    {
        waitObj = new WaitForFixedUpdate();
        StartCoroutine(OnStartCoroutine());
    }

    public IEnumerator OnStartCoroutine()
    {
        while (canRun)
        {
            yield return waitObj;
            print("Repeating");
        }
    }
}
