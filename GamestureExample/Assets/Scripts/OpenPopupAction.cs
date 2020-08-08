using Gamesture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPopupAction : GButtonAction
{
    [SerializeField] private PopupController popup;

    public override void InvokeButtonAction() => popup?.OnEnable();
}
