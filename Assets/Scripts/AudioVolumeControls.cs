using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AudioVolumeControls : MonoBehaviour
{
    public Slider VolumeSlider;
    public TextMeshProUGUI VolumeText;


    void Start()
    {
        VolumeSlider.onValueChanged.AddListener((newVolume) =>
        {
            SingletonItem.Instance.UpdateVolume(newVolume);
            VolumeText.SetText(newVolume.ToString("F0"));
        });
    }
}
