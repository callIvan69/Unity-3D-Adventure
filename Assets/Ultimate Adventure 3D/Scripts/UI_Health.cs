using UnityEngine;
using UnityEngine.UI;

public class UI_Health : MonoBehaviour
{
    [SerializeField] private Destructible destructible;
    [SerializeField] private Image sliderFill;

    private void Start()
    {
        destructible.ChangeHitPoints.AddListener(OnChangeHitPoint);
    }
    private void OnDestroy()
    {
        destructible.ChangeHitPoints.RemoveListener(OnChangeHitPoint);
    }
    private void OnChangeHitPoint()
    {
        sliderFill.fillAmount = destructible.GetHitPoints() / 100.0f;
    }
}
