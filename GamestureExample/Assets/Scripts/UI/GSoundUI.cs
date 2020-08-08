using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GSoundUI : MonoBehaviour
{
    private int idx;
    private bool isActive;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Button button;


    // Start is called before the first frame update
    void Start()
    {
        if (!text) text = GetComponentInChildren<TextMeshProUGUI>();
        if (!button) button = GetComponentInChildren<Button>();
    }

    public void InitGSoundUI(int idx, GSound sound)
    {
        this.idx = idx;
        text.text = sound.SoundTitle;
        isActive = sound.IsActive;
        var listOfSprites = GameController.Instance.spriteDBController.sprites;
        button.image.sprite = isActive ? listOfSprites[Random.Range(1, listOfSprites.Count)] : listOfSprites[0];
    }

    public void OnButtonClick()
    {
        isActive = !isActive;
        var listOfSprites = GameController.Instance.spriteDBController.sprites;
        button.image.sprite = isActive ? listOfSprites[Random.Range(1, listOfSprites.Count)] : listOfSprites[0];
        GameController.Instance.soundDBController.gsounds[idx].IsActive = isActive;
    }
}
