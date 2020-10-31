using UnityEngine;

namespace Operations.Vector {
    [AddComponentMenu("MonoMath/Operations/Vector/Signed Angle")]
    public class SignedAngle : OperatorMono<Vector3, Vector3, float> {
        public ValueYieldMono VectorA;
        public ValueYieldMono VectorB;
        public override Vector3 TVal1 => (Vector3)VectorA.Value();
        public override Vector3 TVal2 => (Vector3)VectorB.Value();
        public override float Calc(Vector3 tVal1, Vector3 tVal2) {
            var num1 = tVal1.x * tVal2.y - tVal1.y * tVal2.x;
            var num2 = Vector3.Dot(tVal1, tVal2);
            return Mathf.Atan2(num1, num2);
        }
    }
}