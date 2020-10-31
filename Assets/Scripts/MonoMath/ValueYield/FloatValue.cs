using UnityEngine;

namespace MonoMath.ValueYield {
    [AddComponentMenu("MonoMath/Values/Float")]
    public class FloatValue : ValueYieldMono<float> {
        public float Float;
        public override float TRetValue() {
            return Float;
        }
    }
}