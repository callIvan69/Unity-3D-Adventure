using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 speed;
    [SerializeField] private float timeToRotate;

    private void Update()
    {
        transform.Rotate(speed * Time.deltaTime);

        timeToRotate -= Time.deltaTime;

        if (timeToRotate <= 0)
        {
            timeToRotate = 0;

            enabled = false;
        }
    }

}
