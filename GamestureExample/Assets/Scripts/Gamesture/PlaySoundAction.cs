using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamesture
{
    public class PlaySoundAction : GButtonAction
    {
        public override void InvokeButtonAction() => GameController.Instance.audioSourceController.PlaySound(GameController.Instance.soundDBController.GetRandomSound());
    }
}
