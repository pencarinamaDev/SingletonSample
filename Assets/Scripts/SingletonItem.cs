using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonItem : MonoBehaviour
{

    public static SingletonItem Instance;
    public float AudioVolume;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
    public void UpdateVolume(float newVolume)
    {
        AudioVolume = newVolume;
    }
}
