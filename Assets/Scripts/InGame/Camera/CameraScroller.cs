using UnityEngine;

namespace InGame.Camera
{
    public class CameraScroller: MonoBehaviour
    {
        [SerializeField] private float scrollSpeed;
        [SerializeField] private Vector2 halfCameraView;

        private Transform _modelTransform;

        private void Awake()
        {
            _modelTransform = transform;
        }

        private void Update()
        {
            _modelTransform.Translate(Vector2.right * (scrollSpeed*Time.deltaTime));
        }

        public void ClampPosition2InCamera(ref Vector3 position)
        {
            var cameraPosition = _modelTransform.position;
            position.x = Mathf.Clamp(position.x, cameraPosition.x - halfCameraView.x,
                cameraPosition.x + halfCameraView.x);
            position.y = Mathf.Clamp(position.y, cameraPosition.y - halfCameraView.y,
                cameraPosition.y + halfCameraView.y);
        }
    }
}