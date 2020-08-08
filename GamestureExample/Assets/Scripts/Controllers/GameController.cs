using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    public SoundDBController soundDBController { get; private set; }
    public SpriteDBController spriteDBController { get; private set; }
    public AudioSourceController audioSourceController { get; private set; }

    private void Awake()
    {
        Instance = this;
        soundDBController = GetComponentInChildren<SoundDBController>();
        spriteDBController = GetComponentInChildren<SpriteDBController>();
        audioSourceController = GetComponentInChildren<AudioSourceController>();
        DontDestroyOnLoad(this);
    }
}
