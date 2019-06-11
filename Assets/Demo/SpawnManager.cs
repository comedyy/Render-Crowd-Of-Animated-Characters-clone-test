using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// demo使用，分配大量的活动的角色
/// </summary>
public class SpawnManager : MonoBehaviour {

    #region 字段

    public GameObject spawnPrefab;
    public int gridWidth;
    public int gridHeight;

    #endregion


    #region 方法

    GameObject RondomOne() {
        return spawnPrefab;
    }

    void Start()
    {
        for(int i = 0; i < gridWidth; i++)
        {
            for(int j = 0; j < gridHeight; j++)
            {
                GameObject o =  Instantiate<GameObject>(RondomOne(), new Vector3(i * 2, 0, j * 2), Quaternion.identity);
                o.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                MeshRenderer r =  o.GetComponent<MeshRenderer>();
                MaterialPropertyBlock mp = new MaterialPropertyBlock();
                mp.SetFloat("_TextureIndex", Random.Range(0, 4));
                r.SetPropertyBlock(mp);
            }
        }
    }


    #endregion

}
