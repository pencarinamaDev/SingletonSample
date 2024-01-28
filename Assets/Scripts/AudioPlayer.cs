using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _audioSource.Play();
    }

    /// <summary>
    /// Khusus untuk showcase cara kerja singleton
    /// Perubahan value jangan dipasang di Update
    /// </summary>
    private void Update()
    {
        _audioSource.volume = SingletonItem.Instance.AudioVolume / 100;
    }
}
