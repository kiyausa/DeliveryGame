using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class UIImage : MonoBehaviour
{
    //  ���g��TextMeshProUGUI�R���|�[�l���g���i�[
    private Image image;

    //  �ێ�����摜�f�[�^���i�[
    [SerializeField] private Sprite sprite;

    [SerializeField] private Color color;

    //  �摜�f�[�^�̃A�N�Z�T
    public Sprite Sprite { get => sprite; set {  sprite = value; } }

    public Color Color { get => color; set { color = value; } }

    private bool init = false;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        if (!init)
        {
            image = this.gameObject.GetComponent<Image>();
            init = true;
        }
    }

    private void FixedUpdate()
    {
        SetImage();
    }

    public void SetImage()
    {
        Initialize();
        image.sprite = Sprite;
        image.color = color;
        image.SetNativeSize();
    }

    public void OnValidate()
    {
        SetImage();
    }
}
  