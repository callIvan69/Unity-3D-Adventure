using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthImage : MonoBehaviour
{
    [SerializeField] private Destructible destructible;
    [SerializeField] private TMP_Text text;
    [SerializeField] private Image image;

    private void Awake()
    {
        text.text = destructible.GetHitPoints().ToString();

        destructible.ChangeHitPoints.AddListener(OnChangeHitPoint);
    }
    private void OnDestroy()
    {
        destructible.ChangeHitPoints.RemoveListener(OnChangeHitPoint);
    }
    private void OnChangeHitPoint()
    {
        text.text = destructible.GetHitPoints().ToString();
    }
}
