using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Bag : MonoBehaviour
{
    [SerializeField] private new AudioSource audio;

    [HideInInspector] public UnityEvent OnPickedUp;

    private int amountKey;

    public int AmountKey => amountKey;

    public void AddKey(int amount)
    {
        amountKey += amount;

        OnPickedUp.Invoke();

        audio.Play();
    }
    public int  GetAmountKey()
    {
        return amountKey;
    }
    public bool DrawKey(int amount)
    {
        if (amountKey - amount < 0) return false;

        amountKey -= amount;

        return true;
    }
} 