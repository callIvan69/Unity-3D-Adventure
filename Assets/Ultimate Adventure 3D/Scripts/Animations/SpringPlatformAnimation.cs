using SimpleFPS;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpringPlatformAnimation : MonoBehaviour
{
    [SerializeField] private Transform platform;

    private Vector3 currentPosition;
    
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            currentPosition = platform.transform.position;

            platform.transform.position = new Vector3(platform.transform.position.x, platform.transform.position.y - 1f, platform.transform.position.z);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        platform.transform.position = currentPosition;
    }
}
