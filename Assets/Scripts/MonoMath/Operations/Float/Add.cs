using UnityEngine;

namespace MonoMath.Operations.Float {
    [AddComponentMenu("MonoMath/Operations/Float/Float Add")]
    public class Add : OperatorMono<float, float, float> {
        public ValueYieldMono ValueA;
        public ValueYieldMono ValueB;
        public override float TVal1 => (float) ValueA.Value();
        public override float TVal2 => (float) ValueB.Value();

        public override float Calc(float tVal1, float tVal2) {
            return tVal1 + tVal2;
        }
    }
}