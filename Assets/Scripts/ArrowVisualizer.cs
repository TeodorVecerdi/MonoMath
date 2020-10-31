using System;
using Operations.Vector;
using UnityEngine;

public class ArrowVisualizer : MonoBehaviour {
    public FromAToB Vector;

    private void Update() {
        transform.position = Vector.TVal1;
        transform.LookAt(Vector.TVal2);
        transform.localScale = new Vector3(1, 1, ((Vector3) Vector.Value()).magnitude);
    }
}