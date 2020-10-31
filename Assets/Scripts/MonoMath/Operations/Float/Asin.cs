    using UnityEngine;

    namespace MonoMath.Operations.Float {
        [AddComponentMenu("MonoMath/Operations/Float/Asin")]
        public class Asin : OperatorMono<float, float> {
            public ValueYieldMono Sin;
            public override float TVal => (float) Sin.Value();

            public override float Calc(float tVal) {
                return Mathf.Asin(tVal);
            }
        }
    }