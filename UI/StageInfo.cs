using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.InputSystem;

public class StageInfo : MonoBehaviour
{
    [SerializeField] private RectTransform stageName;
    [SerializeField] private RectTransform spaceName;

    [SerializeField] private RectTransform back;

    [SerializeField] private TextMeshProUGUI Stagetext;
    [SerializeField] private TextMeshProUGUI Spacetext;

    [SerializeField] private float f;
    int flag = 0;

    int count = 0;

    private int prestate = 0;

    // Start is called before the first frame update
    void Start()
    {
        f = 0f;
        Initialize();
        changeInfo();
    }

    private void changeInfo()
    {
        float size = 2f;
        float x = (1920 - stageName.sizeDelta.x * size) / 2f;
        float y = (1080 - stageName.sizeDelta.y * size) / 2f;
        var sequence = DOTween.Sequence()
            .AppendCallback(() => stageName.localScale = Vector3.one * size)
            .Append(stageName.DOAnchorPos(new Vector3(x, -y, 0), 1f).SetEase(Ease.InOutExpo))
            .Join(back.DOScaleX(40, 1f).SetEase(Ease.InOutExpo))
            .Join(back.DOAnchorPos(new Vector3(960, -540, 0), 1f).SetEase(Ease.InOutExpo))
            .AppendInterval(1f)
            .Join(back.DOScaleX(14, 0.5f).SetEase(Ease.InOutExpo))
            .Append(stageName.DOAnchorPos(new Vector3(72f, -80f, 0), 1f).SetEase(Ease.InOutExpo))
            .Join(stageName.DOScale(Vector3.one, 1f))
            .Join(back.DOAnchorPos(new Vector3(0, -120, 0), 1f).SetEase(Ease.InOutExpo))
            .Append(spaceName.DOAnchorPos(new Vector3((72 + (Stagetext.fontSize * Stagetext.text.Length)), 80f, 0), 0f))
            .AppendCallback(() => Spacetext.alpha = 1f)
            .Append(spaceName.DOAnchorPos(new Vector3((72 + (Stagetext.fontSize * Stagetext.text.Length)), -80f, 0), 1f).SetEase(Ease.InOutExpo));
    }

    private void Initialize()
    {
        Stagetext = stageName.GetComponent<TextMeshProUGUI>();
        Spacetext = spaceName.GetComponent<TextMeshProUGUI>();
        stageName.anchoredPosition = new Vector3(1920, -470, 0);
        stageName.sizeDelta = new Vector2(Stagetext.fontSize * Stagetext.text.Length, 70);
        Spacetext.alpha = 0f;
    }

    private void FixedUpdate()
    {

        int state = PlaceManegement.Instance.Place;

        if (state != prestate)
        {
            switch (state)
            {
                case 0:
                    ChangeSpaceName(spaceName, "-フロントスペース");
                    break;
                case 1:
                    ChangeSpaceName(spaceName, "-社員スペース");
                    break;
                case 2:
                    ChangeSpaceName(spaceName, "-社長ペース");
                    break;
                case 3:
                    ChangeSpaceName(spaceName, "-ガレージスペース");
                    break;
                case 4:
                    ChangeStageName(stageName, "業務ボード");
                    break;
                case 5:
                    ChangeStageName(stageName, "オフィス");
                    break;
            }
        }

        prestate = state;
    }

    private void ChangeSpaceName(RectTransform space, string newText)
    {
        var sequence = DOTween.Sequence()
            .AppendCallback(() => Spacetext.text = newText)
            .Append(stageName.DOAnchorPos(new Vector3(72f, -80f, 0f), 1f).SetEase(Ease.OutExpo))
            .Append(space.DOAnchorPos(new Vector3((72 + (Stagetext.fontSize * Stagetext.text.Length)), 80f, 0), 1f).SetEase(Ease.OutExpo))
            .Join(space.DOAnchorPos(new Vector3((72 + (Stagetext.fontSize * Stagetext.text.Length)), -80f, 0), 1f).SetEase(Ease.OutExpo));
    }

    private void ChangeStageName(RectTransform stage, string newText)
    {
        int length = newText.Length;
        var sequence = DOTween.Sequence()
            .Append(stage.DOAnchorPos(new Vector3(72f, 80f, 0f), 1f).SetEase(Ease.OutExpo))
            .Join(spaceName.DOAnchorPos(new Vector3((72 + (Stagetext.fontSize * length)), 80f, 0), 1f).SetEase(Ease.OutExpo))
            .AppendCallback(() => Stagetext.text = newText)
            .AppendCallback(() => stageName.sizeDelta = new Vector2(Stagetext.fontSize * length, 70))
            .Append(stage.DOAnchorPos(new Vector3(72f, -80f, 0f), 1f).SetEase(Ease.OutExpo));
    }
}
