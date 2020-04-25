using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerStayEvent, triggerExitEvent;
    public Slider health;
    public FloatData healthNum;
    public bool doesDamage;
    
    private void OnTriggerEnter(Collider other)
    {
        if(doesDamage)
        {
            healthNum.value -= 0.333f;
            if(healthNum.value < 0.1f)
            {
                triggerEnterEvent.Invoke();
            }
        }
        else
        {
            healthNum.value = 0f;
            triggerEnterEvent.Invoke();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        triggerStayEvent.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }

    void Start()
    {
        healthNum.value = 1.0f;
    }

    void Update()
    {
        health.value = healthNum.value;
    }
}