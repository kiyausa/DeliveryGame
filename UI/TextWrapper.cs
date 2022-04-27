using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextWrapper : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMesh;
    private RectTransform _rect;

    private void Start()
    {
        _textMesh = GetComponent<TextMeshProUGUI>();
    }

    /// <summary>
    /// 任意の文字列をTextMeshProのテキストにセットする
    /// </summary>
    /// <param name="text"></param>
    public void SetTextMesh(string text)
    {
        _textMesh.SetText(text);
    }

    /// <summary>
    /// 文字列を任意のサイズに変更する
    /// </summary>
    /// <param name="size"></param>
    public void SetFontSize(int size)
    {
        _textMesh.fontSize = size;
    }

    public void SetPosition(float x, float y, float z)
    {
        _rect.position = new Vector3(x, y, z);
    }

    public void SetAlignment(int types)
    {
        switch(types)
        {
            case 0: _textMesh.alignment = TextAlignmentOptions.Left;
                    break;
        }
    }
}
