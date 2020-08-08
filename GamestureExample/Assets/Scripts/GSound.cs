using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new GSound", menuName = "GAssets/GSound", order = 1500)]
public class GSound : ScriptableObject
{
    [SerializeField] private bool isActive = true;
    public bool IsActive { get => isActive; set => isActive = value; }
    [SerializeField] private string soundTitle = "";
    [SerializeField] private AudioClip audioClip;
    public AudioClip AudioClip { get => audioClip; }
}
