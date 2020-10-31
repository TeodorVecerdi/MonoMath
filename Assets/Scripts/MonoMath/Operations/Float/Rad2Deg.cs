    using UnityEngine;

    namespace MonoMath.Operations.Float {
        [AddComponentMenu("MonoMath/Operations/Float/Radians to Degrees")]
        public class Rad2Deg: OperatorMono<float, float> {
            public ValueYieldMono Radians;
            public override float TVal => (float)Radians.Value();
            public override float Calc(float tVal) {
                return Mathf.Rad2Deg * tVal;
            }
        }
    }