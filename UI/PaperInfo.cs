using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class PaperInfo : MonoBehaviour
{
    [SerializeField] private string title;
    [SerializeField] private string name;
    [SerializeField] private string info;
    [SerializeField] private string level;

    [SerializeField] private TextMeshProUGUI titleobj;
    [SerializeField] private TextMeshProUGUI nameobj;
    [SerializeField] private TextMeshProUGUI infoobj;
    [SerializeField] private TextMeshProUGUI levelobj;

    private void OnValidate()
    {
        PaperInit();
    }

    private void PaperInit()
    {
        SetText(title, titleobj);
        SetText(name, nameobj);
        SetText(info, infoobj);
        SetText(level, levelobj);
    }

    private void SetText(string text, TextMeshProUGUI obj)
    {
        obj.text = text;
        obj.rectTransform.sizeDelta = new Vector2(obj.fontSize * text.Length, 92);
    }
}
