    using UnityEngine;

    namespace MonoMath.Operations.Float {
        [AddComponentMenu("MonoMath/Operations/Float/Divide")]
        public class Divide : OperatorMono<float, float, float> {
            public ValueYieldMono FloatValue1;
            public ValueYieldMono FloatValue2;

            public override float TVal1 => (float)FloatValue1.Value();
            public override float TVal2 => (float)FloatValue2.Value();
            public override float Calc(float tVal1, float tVal2) {
                if (tVal2 == 0) return float.PositiveInfinity;
                return tVal1 / tVal2;
            }
        }
    }