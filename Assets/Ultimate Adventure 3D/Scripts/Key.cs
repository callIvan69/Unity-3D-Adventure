using UnityEngine;

public class Key : PickUp
{
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        Bag bag = other.GetComponent<Bag>();

        if (bag != null)
        {
            bag.AddKey(1);
        }
    }
}
