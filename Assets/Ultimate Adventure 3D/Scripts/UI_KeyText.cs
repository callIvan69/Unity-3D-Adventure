using TMPro;
using UnityEngine;

public class UI_KeyText : MonoBehaviour
{
    [SerializeField] private TMP_Text keyText;

    [SerializeField] private Bag bag;

    private void Start()
    {
        bag.OnPickedUp.AddListener(ChangeKeyText);
    }
    private void OnDestroy()
    {
        bag.OnPickedUp.RemoveListener(ChangeKeyText);
    }
    private void ChangeKeyText()
    {
        keyText.text = bag.GetAmountKey().ToString();
    }
}
