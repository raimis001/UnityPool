using UnityEngine;

public class Spawn : MonoBehaviour
{
    void Start()
    {
          
    }

    private void OnEnable()
    {
        Invoke(nameof(DisableSpawn), 3);
    }

    void DisableSpawn()
    {
        gameObject.SetActive(false);
    }
}
