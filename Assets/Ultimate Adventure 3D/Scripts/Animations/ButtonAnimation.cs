using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFPS;
using Unity.VisualScripting;

public class ButtonAnimation : MonoBehaviour
{
    [SerializeField] private Transform button;

    private Vector3 currentPosition;
    
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            currentPosition = button.transform.position;

            button.transform.position = new Vector3(button.transform.position.x, button.transform.position.y - 0.2f, button.transform.position.z);

            GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        button.transform.position = currentPosition;
    }
}