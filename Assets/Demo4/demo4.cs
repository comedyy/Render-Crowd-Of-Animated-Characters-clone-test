using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo4 : MonoBehaviour {
    #region 字段

	List<float> _percents = new List<float>(){
		0,0.0952381f,0.1904762f,0.2857143f,0.3333333f,0.4285714f,0.5238096f,0.6190476f,1
	};

    public GameObject spawnPrefab;
    public int gridWidth;
    public int gridHeight;

    #endregion


    #region 方法

    GameObject RondomOne() {
        return spawnPrefab;
    }

	Vector2 RandomAni(int index){
		float upper= _percents[index+1];
		float lowerer = _percents[index];
		return new Vector2(lowerer, upper);
	}

    void Start()
    {
		int length = _percents.Count - 1;
		int count = 0;

        for(int i = 0; i < gridWidth; i++)
        {
            for(int j = 0; j <gridHeight; j++)
            {
                GameObject o = Instantiate<GameObject>(spawnPrefab, new Vector3(i * 2, 0, j * 2), Quaternion.identity);
				MeshRenderer r =  o.GetComponent<MeshRenderer>();

				Vector2 vec = RandomAni(count ++ % length);
                MaterialPropertyBlock mp = new MaterialPropertyBlock();
                mp.SetFloat("_From", vec.x);
                mp.SetFloat("_To", vec.y);
                r.SetPropertyBlock(mp);
            }
        }
    }


    #endregion

}
