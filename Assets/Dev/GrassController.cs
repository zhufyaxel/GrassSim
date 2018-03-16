using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassController : MonoBehaviour {
    public float[] d = new float[] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f};
    public float distance = 0.3f;
    public int GrassIntX = 17;
    public GameObject grass;
    public List<GameObject> grasses;
    // Use this for initialization
    private void Start()
    {
        generateGrass();
    }
    public void generateGrass()
    {
        if (grasses.Count > 0)
        {
            foreach (var obj in grasses)
            {
                Destroy(obj);
            }
            grasses = new List<GameObject>();
        }
        if (grass != null)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < GrassIntX; j++)
                {
                    float z = i;
                    float x = j;
                    if (i >= 1)
                    {
                        x += d[i - 1];
                    }
                    Vector3 pos = new Vector3(x * distance, 0, z * distance);
                    var temp = Instantiate(grass, pos, Quaternion.identity);
                    grasses.Add(temp);
                }
            }
        }
    }

    public void setD0 (string nd)
    {
        d[0] = float.Parse(nd);
    }
    public void setD1(string nd)
    {
        d[1] = float.Parse(nd);
    }
    public void setD2(string nd)
    {
        d[2] = float.Parse(nd);
    }
    public void setD3(string nd)
    {
        d[3] = float.Parse(nd);
    }
    public void setD4(string nd)
    {
        d[4] = float.Parse(nd);
    }
    public void setD5(string nd)
    {
        d[5] = float.Parse(nd);
    }
}
