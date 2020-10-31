    using UnityEngine;

    namespace MonoMath.Operations.Float {
        [AddComponentMenu("MonoMath/Operations/Float/Acos")]
        public class Acos : OperatorMono<float, float> {
            public ValueYieldMono Cos;
            public override float TVal => (float) Cos.Value();

            public override float Calc(float tVal) {
                return Mathf.Acos(tVal);
            }
        }
    }