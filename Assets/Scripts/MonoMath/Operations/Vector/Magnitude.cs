    using UnityEngine;

    namespace Operations.Vector {
        [AddComponentMenu("MonoMath/Operations/Vector/Magnitude")]
        public class Magnitude : OperatorMono<Vector3, float> {
            public ValueYieldMono Vector;
            public override Vector3 TVal => (Vector3)Vector.Value();

            public override float Calc(Vector3 tVal) {
                return tVal.magnitude;
            }
        }
    }