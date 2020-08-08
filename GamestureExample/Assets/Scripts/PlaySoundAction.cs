using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamesture
{
    public class PlaySoundAction : GButtonAction
    {
        [SerializeField] private AudioSourceController audioSourceController;
        [SerializeField] private SoundDBController soundDBController;

        public override void InvokeButtonAction() => audioSourceController?.PlaySound(soundDBController?.GetRandomSound());
    }
}
