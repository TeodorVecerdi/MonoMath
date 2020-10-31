using UnityEngine;

namespace MonoMath.ValueYield {
    [AddComponentMenu("MonoMath/Values/Vector")]
    public class VectorValue : ValueYieldMono<Vector3> {
        public Vector3 Vector;
        public override Vector3 TRetValue() {
            return Vector;
        }
    }
}