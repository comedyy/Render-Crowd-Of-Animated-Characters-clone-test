using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript1
{
    [MenuItem("Tools/yyy")]
    static void CreateItem() {
        Object[] selections = Selection.objects;
        int width = 512;
        int height = selections.ToList().Sum(m => (m as Texture2D).height);

        Texture2D texture = new Texture2D(width, height, TextureFormat.RGBAHalf, false);
        int current_height = 0;
        for (int i = 0; i < selections.Length; i++)
        {
            Texture2D t = selections[i] as Texture2D;
            texture.SetPixels(0, current_height, width, t.height, t.GetPixels());
            current_height += t.height;
            Debug.Log(current_height * 1.0f / height);
        }
        texture.Apply();
        AssetDatabase.CreateAsset(texture, ("assets/demo4/x.asset"));
    }
}
