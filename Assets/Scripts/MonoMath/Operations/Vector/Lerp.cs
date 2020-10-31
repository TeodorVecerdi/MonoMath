using UnityEngine;

namespace Operations.Vector {
    [AddComponentMenu("MonoMath/Operations/Vector/Vector Lerp")]
    public class Lerp : OperatorMono<Vector3, Vector3, float, Vector3> {
        public ValueYieldMono VectorA;
        public ValueYieldMono VectorB;
        public ValueYieldMono Time;
        public override Vector3 TVal1 => (Vector3) VectorA.Value();
        public override Vector3 TVal2 => (Vector3) VectorB.Value();
        public override float TVal3 => (float) Time.Value();

        public override Vector3 Calc(Vector3 tVal1, Vector3 tVal2, float tVal3) {
            return Vector3.Lerp(tVal1, tVal2, tVal3);
        }
    }
}