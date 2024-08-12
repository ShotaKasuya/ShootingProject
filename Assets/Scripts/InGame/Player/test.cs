using UnityEngine;
using UnityEngine.InputSystem;

namespace InGame.Player
{
    // 値型
    public struct test
    {
        private Transform _modelTransform;
        private PlayerInput _playerInput;
        private InputAction _moveAction;

        public void a(float value)
        {
            _modelTransform.Translate(value, value, value);
        }
    }
}