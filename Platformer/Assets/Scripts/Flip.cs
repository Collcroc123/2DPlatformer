using UnityEngine;

public class Flip : MonoBehaviour
{
    public KeyCode key1 = KeyCode.LeftArrow, key2 = KeyCode.RightArrow, key3 = KeyCode.A, key4 = KeyCode.D;
    public float dir1 = 0, dir2 = 180;
    private Vector3 direction;

    void Update()
    {
        if(Input.GetKeyDown(key1) || Input.GetKeyDown(key3))
        {
            transform.rotation = Quaternion.Euler(0,dir1,0);
        }
        if(Input.GetKeyDown(key2) || Input.GetKeyDown(key4))
        {
            transform.rotation = Quaternion.Euler(0,dir2,0);
        }
    }
}