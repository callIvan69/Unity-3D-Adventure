using SimpleFPS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SphereTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent Enter;
    [SerializeField] private GameObject messageBox;
    [SerializeField] private MeshRenderer Sphere1;
    [SerializeField] private MeshRenderer Sphere2;
    [SerializeField] private MeshRenderer Sphere3;

    private bool isActive = false;

    protected void OnTriggerEnter(Collider other)
    {
        if (isActive == true) return;

        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            if (Sphere1.enabled == true && Sphere2.enabled == true && Sphere3.enabled == true)
            {
                Enter.Invoke();
                isActive = true;
            }
            else
            {
                messageBox.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        messageBox.SetActive(false);
    }
}
