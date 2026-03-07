using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFPS;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Teleporter target;
    [SerializeField] private new AudioSource audio;
    [HideInInspector] public bool IsRecive;

    private void OnTriggerEnter(Collider other)
    {
        if (IsRecive == true) return;

        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if(fps != null)
        {
            target.IsRecive = true;
            
            fps.transform.position = target.transform.position;

            audio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if(fps != null )
        {
            IsRecive = false;
        }
    }
}
 