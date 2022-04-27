using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class ResultDOTween : MonoBehaviour
{
    int counter = 0;
    public TextMeshProUGUI text;
    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        
        if (counter == 120)
        {
            var tween = DOTween.Sequence()
            .AppendCallback(() => text.transform.localScale = Vector3.one * 1.25f)
            .Append(text.transform.DOScale(Vector3.one, 0.5f))
            .AppendInterval(0.5f);
            counter = 0;
        }

        counter++;
    }
}
