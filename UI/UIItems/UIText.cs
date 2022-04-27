using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class UIText : MonoBehaviour
{
    //  自身のTextMeshProUGUIコンポーネントを格納
    private TextMeshProUGUI textmesh;

    [SerializeField] private string text;   //  保持するテキストデータを格納
    [SerializeField] private int size;      //  保持するフォントサイズデータを格納

    private int length;

    //  テキストデータのアクセサ
    public string Text { get { return this.text; } set { this.text = value; } }
    //  フォントサイズデータのアクセサ
    public int Size { get { return this.size; } set { this.size = value; } }

    private int width;

    private bool init = false;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        textmesh = this.gameObject.GetComponent<TextMeshProUGUI>();
        length = Text.Length;
        init = true;
    }

    public void SetText()
    {
        textmesh.text = Text;
    }

    public void SetSize()
    {
        textmesh.fontSize = Size;
    }

    public void SetWidth()
    {
        textmesh.rectTransform.sizeDelta = new Vector2(Size * length, Size + 8);
    }

    public void OnValidate()
    {
        Change();
    }

    public void Change()
    {
        Initialize();
        SetText();
        SetSize();
        SetWidth();
    }
}
