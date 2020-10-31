    using UnityEngine;

    namespace MonoMath.Operations.Float {
        [AddComponentMenu("MonoMath/Operations/Float/Degrees to Radians")]
        public class Deg2Rad: OperatorMono<float, float> {
            public ValueYieldMono Degrees;
            public override float TVal => (float)Degrees.Value();
            public override float Calc(float tVal) {
                return Mathf.Deg2Rad * tVal;
            }
        }
    }