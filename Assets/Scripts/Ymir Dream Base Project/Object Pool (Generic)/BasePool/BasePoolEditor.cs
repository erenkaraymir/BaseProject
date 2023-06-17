using UnityEditor;

[CustomEditor(typeof(BasePool<>))]
public class BasePoolEditor : Editor
{
    private SerializedProperty _baseParentProp;
    private SerializedProperty _baseParentTransformProp;


    private void OnEnable()
    {
        _baseParentProp = serializedObject.FindProperty("_IsBaseParent");
        _baseParentTransformProp = serializedObject.FindProperty("_baseParentTransform");
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        serializedObject.Update();

        if (_baseParentProp.boolValue)
        {
            EditorGUILayout.PropertyField(_baseParentTransformProp);
        }

        serializedObject.ApplyModifiedProperties();
    }
}