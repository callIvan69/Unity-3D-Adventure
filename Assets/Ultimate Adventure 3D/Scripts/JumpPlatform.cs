using SimpleFPS;
using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    [SerializeField] private int jumpForce;
    [SerializeField] private new AudioSource audio;

    private float previousJumpForce;

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            previousJumpForce = fps.m_JumpSpeed;

            fps.m_JumpSpeed += jumpForce;
            fps.m_Jump = true;
            audio.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed = previousJumpForce;
        }
    }
}
