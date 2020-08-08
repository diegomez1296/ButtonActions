using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SoundDBController : MonoBehaviour
{
    public List<GSound> gsounds;

    public AudioClip GetRandomSound()
    {
        var listOfActiveSounds = gsounds.Where(c => c.IsActive).ToList();
        return listOfActiveSounds[Random.Range(0, listOfActiveSounds.Count())].AudioClip;
    }
}
