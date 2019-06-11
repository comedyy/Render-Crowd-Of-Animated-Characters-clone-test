using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript
{
    [MenuItem("Tools/xxx")]
    static void CreateItem() {
        Object[] selections = Selection.objects;

        Texture2DArray texture_array = new Texture2DArray(1024, 1024, 4, TextureFormat.RGB24, false);
        for (int i = 0; i < selections.Length; i++)
        {
            Graphics.CopyTexture(selections[i] as Texture2D, 0, texture_array, i);
        }
        AssetDatabase.CreateAsset(texture_array, "Assets/xxx.asset");
    }
}
