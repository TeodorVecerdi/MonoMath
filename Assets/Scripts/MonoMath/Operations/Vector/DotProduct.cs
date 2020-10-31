    using UnityEngine;

    namespace Operations.Vector {
        [AddComponentMenu("MonoMath/Operations/Vector/Dot Product")]
        public class DotProduct : OperatorMono<Vector3, Vector3, float> {
            public ValueYieldMono VectorA;
            public ValueYieldMono VectorB;
        
            public override Vector3 TVal1 => (Vector3)VectorA.Value();
            public override Vector3 TVal2 => (Vector3)VectorB.Value();
            public override float Calc(Vector3 tVal1, Vector3 tVal2) {
                return Vector3.Dot(tVal1, tVal2);
            }
        }
    }