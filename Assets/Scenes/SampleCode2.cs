using UnityEngine;

public class SampleCode2 : MonoBehaviour
{
    public Vector2 SizeDelta;

#if UNITY_EDITOR
    private void OnValidate()
    {
        GetComponent<RectTransform>().sizeDelta = SizeDelta;
    }
#endif
}
