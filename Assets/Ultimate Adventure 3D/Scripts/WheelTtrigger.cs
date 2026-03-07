using SimpleFPS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WheelTtrigger : MonoBehaviour
{
    [SerializeField] UnityEvent Enter;
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            Enter.Invoke();
            
        }
    }
    
}
