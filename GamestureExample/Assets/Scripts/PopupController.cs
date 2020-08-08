using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PopupStatus
{
    DEFAULT,
    OPEN,
    CLOSE
}

public class PopupController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        if (!animator) animator = GetComponent<Animator>();
        animator.SetInteger("PanelState", (int)PopupStatus.DEFAULT);
    }

    public void OnEnable()
    {
        animator.SetInteger("PanelState", (int)PopupStatus.OPEN);
    }

    public void OnDisable()
    {
        animator.SetInteger("PanelState", (int)PopupStatus.CLOSE);
    }
}
