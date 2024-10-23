using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;

    [SerializeField]
    Transform prefabPosition;

    [SerializeField]
    List<GameObject> prefabs;

    int current = 0;

    private void OnMouseDown()
    {
        //Instantiate(prefab, prefabPosition.position, prefabPosition.rotation);
        //prefabs[current].SetActive(true);
        //current++;

        GameObject g = Pool.GetPool("Sphere");

        g.transform.SetLocalPositionAndRotation(prefabPosition.position, prefabPosition.rotation);


    }
}
