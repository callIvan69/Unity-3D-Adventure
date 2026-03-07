using UnityEngine.Events;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    [HideInInspector] public UnityEvent Die;
    [HideInInspector] public UnityEvent ChangeHitPoints;
    [SerializeField] private Transform respawnPoint;

    public int hitPoints;
    private bool isDie = false;

    public int MaxHitPoints;

    private void Start()
    {
        hitPoints = MaxHitPoints;
        ChangeHitPoints.Invoke();
    }
    public void ApplyDamage(int damage)
    {
        hitPoints -= damage;

        ChangeHitPoints.Invoke();

        if (hitPoints <= 0)
        {
            Kill();
        }
    }
    public void Kill()
    {
        if (isDie == true) return;
        isDie = true;
        Respawn();
    }
    public int GetHitPoints()
    {
        return hitPoints;
    }

    private void Respawn()
    {
        if (isDie == true)
        {
            transform.position = respawnPoint.position;
            hitPoints = MaxHitPoints;
            ChangeHitPoints.Invoke();
            isDie = false;
        }
    }
}