using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class SetText: MonoBehaviour {
    public ValueYieldMono Value;
    public string Title;
    
    private TMP_Text text;
    private void Awake() {
        text = GetComponent<TMP_Text>();
    }

    private void Update() {
        text.text = $"{Title}\n{Value.Value()}";
    }
}