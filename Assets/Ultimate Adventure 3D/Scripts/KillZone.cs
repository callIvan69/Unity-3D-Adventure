using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destructible destructable = other.GetComponent<Destructible>();

        if (destructable != null)
        {
            destructable.Kill();
        }
    }
}
