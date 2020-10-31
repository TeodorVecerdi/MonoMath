using UnityEngine;

namespace MonoMath.Operations.Float {
    [AddComponentMenu("MonoMath/Operations/Float/Float Lerp")]
    public class Lerp : OperatorMono<float, float, float, float> {
        public ValueYieldMono ValueA;
        public ValueYieldMono ValueB;
        public ValueYieldMono Time;
        public override float TVal1 => (float) ValueA.Value();
        public override float TVal2 => (float) ValueB.Value();
        public override float TVal3 => (float) Time.Value();

        public override float Calc(float tVal1, float tVal2, float tVal3) {
            return Mathf.Lerp(tVal1, tVal2, tVal3);
        }
    }
}