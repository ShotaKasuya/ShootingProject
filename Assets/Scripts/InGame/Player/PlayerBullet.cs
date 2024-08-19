using UnityEngine;

    public class PlayerBullet : MonoBehaviour
    {
        [SerializeField] private int basePower = 1;
        [SerializeField] private float baseSpeed = 1f;

        private Transform _modelTransform;
        private Vector2 _moveVector = Vector2.right;

        private void Awake()
        {
            _modelTransform = transform;
        }

        private void Update()
        {
            var vec = _moveVector * (Time.deltaTime * baseSpeed);
            _modelTransform.Translate(vec);
        }

        public void SetMoveVector(Vector2 vector2)
        {
            _moveVector = vector2;
        }
    }