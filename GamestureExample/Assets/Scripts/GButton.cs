using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gamesture
{
    public class GButton : MonoBehaviour
    {
        [SerializeField] private Button button;

        void Start()
        {
            if (!button) button = GetComponent<Button>();
            button.onClick.AddListener(() =>  OnButtonClick());
        }

        private void OnButtonClick() => GetComponent<GButtonAction>()?.InvokeButtonAction();
    }
}
