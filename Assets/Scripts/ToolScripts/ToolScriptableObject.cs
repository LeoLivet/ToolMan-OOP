using UnityEngine;

[CreateAssetMenu(fileName = "ToolScriptableObject", menuName = "Scriptable Objects/ToolScriptableObject")]
public class ToolScriptableObject : ScriptableObject
{
    public string toolName;
    public bool canScrew;
    public bool canNail;
}
