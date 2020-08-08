using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class SoundPanelUI : MonoBehaviour
{
    [SerializeField] private GSoundUI gsoundUIPrefab;
    [SerializeField] private Transform soundPanel;
    [HideInInspector] public List<GSoundUI> listOfSounds;


    private IEnumerator Start()
    {
        if (!soundPanel) soundPanel = this.transform;
        yield return new WaitForEndOfFrame();
        GenerateListOfSounds();
    }

    private void GenerateListOfSounds()
    {
        if (listOfSounds.Count > 0) ClearList();

        for (int i = 0; i < GameController.Instance.soundDBController.gsounds.Count; i++)
        {
            var copy = Instantiate(gsoundUIPrefab, soundPanel);
            copy.InitGSoundUI(i, GameController.Instance.soundDBController.gsounds[i]);
            listOfSounds.Add(copy);
        }
    }

    private void ClearList()
    {
        foreach (var item in listOfSounds)
        {
            Destroy(item.gameObject);
        }
    }
}
