# PlayerController

---
* キャッシュを行う
* 入力受付

## キャッシュ

GetComponentは処理が重いため、
初期化処理(Awake, Start)で行っておき、
取っておいたものでなんとかできると良い

```csharp
    private Transform _modelTransform;
    private PlayerInput _playerInput;
    private InputAction _moveAction;

    private void Awake()
    {
        _modelTransform = transform;
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions["Move"];
    }
```

## 入力受付

今回、PlayerInputを利用した。

[参考資料1](https://nekojara.city/unity-input-system-player-input)

## 移動範囲の制限

```csharp
    private void ClampMove()
    {
        var position = _modelTransform.position;

        position.y = Clamp(position.y, minY, maxY);

        _modelTransform.position = position;
    }

    private  float Clamp(float value, float min, float max)
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
```

## 攻撃

