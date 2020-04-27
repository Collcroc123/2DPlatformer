using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html
    public bool canMove;
    private Vector3 startPos;
    private Vector3 endPos;
    private float speed = 1.0f;
    private float distance;
    private float journey;
    private float length;
    private float startTime;

    void Start()
    {
        startPos = transform.position;
        endPos = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
        startTime = Time.time;
        length = Vector3.Distance(startPos, endPos);
        StartCoroutine(moveEnemy());
    }

    IEnumerator moveEnemy()
    {
        while (canMove)
        {
            distance = (Time.time - startTime) * speed;
            journey = distance/length;
            transform.position = Vector3.Lerp(startPos, endPos, Time.deltaTime);
            yield return new WaitForSeconds(1f);
            transform.position = Vector3.Lerp(endPos, startPos, Time.deltaTime);
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(1f);
    }
}
