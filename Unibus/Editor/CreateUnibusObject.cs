using UnityEngine;
using UnityEditor;

namespace UnibusEvent
{
    public sealed class CreateUnibusObject
    {
        [MenuItem("GameObject/Unibus/Unibus", false, 10)]
        static void UnibusObjectGenerate(MenuCommand menuCommand)
        {
            GameObject go = GameObject.Instantiate(Resources.Load<GameObject>("unibus/unibus"));
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
            Selection.activeObject = go;
        }
    }
}
