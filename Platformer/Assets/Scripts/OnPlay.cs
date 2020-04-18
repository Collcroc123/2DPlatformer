using UnityEngine;
using UnityEngine.Events;

public class OnPlay : MonoBehaviour
{
    public UnityEvent play;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            play.Invoke();
        }
    }
}
