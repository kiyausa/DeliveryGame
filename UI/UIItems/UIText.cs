using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class UIText : MonoBehaviour
{
    //  ���g��TextMeshProUGUI�R���|�[�l���g���i�[
    private TextMeshProUGUI textmesh;

    [SerializeField] private string text;   //  �ێ�����e�L�X�g�f�[�^���i�[
    [SerializeField] private int size;      //  �ێ�����t�H���g�T�C�Y�f�[�^���i�[

    private int length;

    //  �e�L�X�g�f�[�^�̃A�N�Z�T
    public string Text { get { return this.text; } set { this.text = value; } }
    //  �t�H���g�T�C�Y�f�[�^�̃A�N�Z�T
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
