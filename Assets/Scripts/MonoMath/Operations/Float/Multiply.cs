    using UnityEngine;

    namespace MonoMath.Operations.Float {
        [AddComponentMenu("MonoMath/Operations/Float/Float Multiply")]
        public class Multiply : OperatorMono<float, float, float> {
            public ValueYieldMono VectorLength1;
            public ValueYieldMono VectorLength2;

            public override float TVal1 => (float)VectorLength1.Value();
            public override float TVal2 => (float)VectorLength2.Value();
            public override float Calc(float tVal1, float tVal2) {
                return tVal1 * tVal2;
            }
        }
    }