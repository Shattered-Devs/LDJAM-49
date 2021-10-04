using System;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    private void Start()
    {
        var instance = Instantiate(prefab);
        DontDestroyOnLoad(instance);
    }
}
