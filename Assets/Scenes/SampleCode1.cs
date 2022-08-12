using UnityEngine;

public class SampleCode1 : MonoBehaviour
{
    public Vector2 SizeDelta;

#if UNITY_EDITOR
    private void OnValidate()
    {
        //�C�x���g�n���h����ǉ�
        UnityEditor.EditorApplication.update += OnValidateImpl;
    }

    void OnValidateImpl()
    {
        //�C�x���g�n���h�����폜
        UnityEditor.EditorApplication.update -= OnValidateImpl;
        //���g���폜�ς݂ł���΂Ȃɂ����Ȃ�
        if (this == null) return;
        //�T�C�Y���X�V����
        GetComponent<RectTransform>().sizeDelta = SizeDelta;
    }
#endif
}
