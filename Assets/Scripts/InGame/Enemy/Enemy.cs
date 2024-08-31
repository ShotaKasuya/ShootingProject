using InGame.Interface;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private int hpMax;

    private int _hp;

    private void Start()
    {
        _hp = hpMax;
    }

    public void Damage(float power)
    {
        _hp -= (int)power;
        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
