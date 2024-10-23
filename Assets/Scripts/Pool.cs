using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    static List<GameObject> prefabs = new List<GameObject>();

    static Dictionary<string, List<GameObject>> PoolList = new Dictionary<string, List<GameObject>>();

    static Transform parent;

    private void Awake()
    {
        parent = transform;

        for (int i = 0; i < transform.childCount; i++)
        {
            GameObject g = transform.GetChild(i).gameObject;
            prefabs.Add(g);

            PoolList.Add(g.name, new List<GameObject>());
            PoolList[g.name].Add(g);
        }
    }

    public static GameObject GetPool(string name)
    {
        foreach (GameObject g in PoolList[name])
        {
            if (g.activeInHierarchy)
                continue;

            g.SetActive(true);
            return g;
        }

        GameObject prefab = prefabs.Find((o) => o.name == name);

        GameObject go = Instantiate(prefab, parent);

        go.SetActive(true);
        PoolList[name].Add(go);

        return go;
    }

}
