using UnityEngine;

namespace Operations.Vector {
    [AddComponentMenu("MonoMath/Operations/Vector/From PointA to PointB")]
    public class FromAToB : OperatorMono<Vector3, Vector3, Vector3> {
        public ValueYieldMono PointA;
        public ValueYieldMono PointB;
        public override Vector3 TVal1 => (Vector3)PointA.Value();
        public override Vector3 TVal2 => (Vector3)PointB.Value();

        public override Vector3 Calc(Vector3 tVal1, Vector3 tVal2) {
            return tVal2 - tVal1;
        }
    }
}