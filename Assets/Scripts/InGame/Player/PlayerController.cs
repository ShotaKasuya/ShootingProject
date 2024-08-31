using InGame.Camera;
using InGame.Interface;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

// 参照型
public class PlayerController : MonoBehaviour, IDamageable
{
    // インスタンスフィールド
    [SerializeField] private int hpMax;
    [SerializeField] private float speed;
    [SerializeField] private PlayerBullet playerBullet;
    [SerializeField] private CameraScroller cameraScroller;

    private Transform _modelTransform;
    private PlayerInput _playerInput;
    private InputAction _moveAction;
    private int _hp;

    private void Awake()
    {
        _hp = hpMax;
        _modelTransform = transform;
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions["Move"];
        _playerInput.actions["Attack"].performed += ctx => Attack();
    }

    private void Update()
    {
        Move();

        ClampMove();
    }

    private void Move()
    {
        var input = _moveAction.ReadValue<Vector2>() * (Time.deltaTime * speed);

        _modelTransform.Translate(input);
    }

    private void ClampMove()
    {
        var position = _modelTransform.position;
        
        cameraScroller.ClampPosition2InCamera(ref position);
        _modelTransform.position = position;
    }

    private void Attack()
    {
        var bullet = Instantiate(playerBullet, _modelTransform.position, quaternion.identity);
        
        Destroy(bullet.gameObject, 5f);
    }

    public void Damage(float power)
    {
        _hp -= (int)power;
    }
}