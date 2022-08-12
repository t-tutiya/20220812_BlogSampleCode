using UnityEngine;

public class SampleCode1 : MonoBehaviour
{
    public Vector2 SizeDelta;

#if UNITY_EDITOR
    private void OnValidate()
    {
        //イベントハンドラを追加
        UnityEditor.EditorApplication.update += OnValidateImpl;
    }

    void OnValidateImpl()
    {
        //イベントハンドラを削除
        UnityEditor.EditorApplication.update -= OnValidateImpl;
        //自身が削除済みであればなにもしない
        if (this == null) return;
        //サイズを更新する
        GetComponent<RectTransform>().sizeDelta = SizeDelta;
    }
#endif
}
