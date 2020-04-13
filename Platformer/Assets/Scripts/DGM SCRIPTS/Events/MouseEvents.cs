using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseDownEvent, mouseUpEvent, mouseHoldEvent, mouseEnterEvent, mouseExitEvent;

    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    private void OnMouseUp()
    {
        mouseUpEvent.Invoke();
    }
    /*
    private void OnMouseDrag()
    {
        mouseHoldEvent.Invoke();
    }
    */
    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }

    private void OnMouseExit()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            mouseDownEvent.Invoke();
        }
        else
        {
            mouseExitEvent.Invoke();
        }
    }
}
