using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DungeonCreator))]
public class DungeonCreatorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        DungeonCreator creator = (DungeonCreator)target;

        if (GUILayout.Button("Create New Dungeon"))
        {
            creator.CreateDungeon();
        }
    }
}
