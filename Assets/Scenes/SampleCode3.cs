using UnityEngine;

public class SampleCode3 : MonoBehaviour
{
    public Vector2 SizeDelta;

#if UNITY_EDITOR
    private void OnValidate()
    {
        UnityEditor.EditorApplication.update += OnValidateImpl;
    }

    void OnValidateImpl()
    {
        UnityEditor.EditorApplication.update -= OnValidateImpl;
        GetComponent<RectTransform>().sizeDelta = SizeDelta;
    }
#endif
}
