using InGame.Interface;
using UnityEngine;

public class ShotEnemy : MonoBehaviour, IDamageable
{
    [SerializeField] private int hpMax;
    [SerializeField] private float shotInterval;
    [SerializeField] private GameObject bullet;

    private int _hp;
    private Transform _modelTransform;
    private float _shotIntervalCounter;

    private void Start()
    {
        _hp = hpMax;
        _modelTransform = transform;
    }

    private void Update()
    {
        if (_shotIntervalCounter > shotInterval)
        {
            Instantiate(bullet, _modelTransform.position, _modelTransform.rotation);
        }

        _shotIntervalCounter += Time.deltaTime;
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