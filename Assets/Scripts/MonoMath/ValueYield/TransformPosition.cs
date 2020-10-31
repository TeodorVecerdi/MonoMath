using UnityEngine;

namespace MonoMath.ValueYield {
    [AddComponentMenu("MonoMath/Values/Transform Position")]
    public class TransformPosition : ValueYieldMono<Vector3> {
        public override Vector3 TRetValue() {
            return transform.position;
        }
    }
}