using UnityEngine;
using UnityEngine.InputSystem;

// 参照型
public class PlayerController : MonoBehaviour
{
    // インスタンスフィールド
    [SerializeField] private float speed;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    private Transform _modelTransform;
    private PlayerInput _playerInput;
    private InputAction _moveAction;

    private void Awake()
    {
        _modelTransform = transform;
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions["Move"];
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

        position.y = Clamp(position.y, minY, maxY);

        _modelTransform.position = position;
    }

    private static float Clamp(float value, float min, float max)
    {
        if (value < min)
        {
            return min;
        }

        if (value > max)
        {
            return max;
        }

        return value;
    }
}