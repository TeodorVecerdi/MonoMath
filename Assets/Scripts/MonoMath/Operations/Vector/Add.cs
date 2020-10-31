using UnityEngine;

namespace Operations.Vector {
    [AddComponentMenu("MonoMath/Operations/Vector/Vector Add")]
    public class Add : OperatorMono<Vector3, Vector3, Vector3> {
        public ValueYieldMono VectorA;
        public ValueYieldMono VectorB;
        public override Vector3 TVal1 => (Vector3) VectorA.Value();
        public override Vector3 TVal2 => (Vector3) VectorB.Value();

        public override Vector3 Calc(Vector3 tVal1, Vector3 tVal2) {
            return tVal1 + tVal2;
        }
    }
}