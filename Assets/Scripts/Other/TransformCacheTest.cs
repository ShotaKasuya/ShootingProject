using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Other
{
    public class TransformCacheTest : MonoBehaviour
    {
        private Transform _modelTransform;
        private const int LoopNum = 1000000;

        private void Awake()
        {
            _modelTransform = transform;
        }

        private void Start()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < LoopNum; i++)
            {
                transform.Translate(1, 0, 0);
            }

            stopwatch.Stop();
            Debug.Log($"No Cache Time: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            for (int i = 0; i < LoopNum; i++)
            {
                _modelTransform.Translate(1, 0, 0);
            }

            stopwatch.Stop();
            Debug.Log($"Use Cache Time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}