using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamesture
{
    public class OpenPopupAction : GButtonAction
    {
        [SerializeField] private PopupController popup;

        public override void InvokeButtonAction() => popup?.OnEnable();
    }
}
