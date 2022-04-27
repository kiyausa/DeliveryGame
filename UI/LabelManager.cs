using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelManager : MonoBehaviour
{
    private UIImage icon;
    private UIText icontext, labeltext;

    [SerializeField] private Sprite sprite;
    [SerializeField] private string itext, ltext;
    [SerializeField] private int size;

    private void Initialize()
    {
        Transform trans = this.gameObject.transform;
        icon = trans.GetChild(0).GetComponent<UIImage>();
        icontext = trans.GetChild(1).GetComponent<UIText>();
        labeltext = trans.GetChild(2).GetComponent<UIText>();
    }

    public void OnValidate()
    {
        Initialize();
        icon.Sprite = sprite;
        icontext.Text = itext;
        labeltext.Text = ltext;
        icontext.Size = size / 2;
        labeltext.Size = size;
        icon.SetImage();
        icontext.Change();
        labeltext.Change();
    }
}
