using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Gamesture
{
    public class ShowTextAction : GButtonAction
    {
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private string message;
        [SerializeField] private float time;
        public override void InvokeButtonAction() => StartCoroutine(CoShowText(time));

        private IEnumerator CoShowText(float time)
        {
            text.text = message;
            yield return new WaitForSeconds(time);
            text.text = "";
        }
    }
}
