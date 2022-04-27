using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(DOTweenAnim))]
public class UIDoScale : MonoBehaviour
{
    #region Variable

    [SerializeField]
    float time = 1f;

    [SerializeField]
    RectTransform rect;

    #endregion

    #region Option
    [SerializeField]
    Ease ease;

    [SerializeField]
    bool isloop = false;

    [SerializeField]
    int ltime = -1;

    [SerializeField]
    LoopType loop;
    #endregion

    public void OnDoScale(float val = 1f)
    {
        var anim = rect.DOScale(Vector3.one * val, time).SetEase(ease);
        if (isloop) anim.SetLoops(ltime, loop);
    }

    public void OnDoScalex(float xval = 1f)
    {
        var anim = rect.DOScaleX(1 * xval, time).SetEase(ease);
        if (isloop) anim.SetLoops(ltime, loop);
    }
    public void OnDoScaley(float yval = 1f)
    {
        var anim = rect.DOScaleY(1 * yval, time).SetEase(ease);
        if (isloop) anim.SetLoops(ltime, loop);
    }
    public void OnDoScalez(float zval = 1f)
    {
        var anim = rect.DOScaleZ(1 * zval, time).SetEase(ease);
        if (isloop) anim.SetLoops(ltime, loop);
    }

    public void OnDoScaleReset()
    {
        var anim = rect.DOScale(Vector3.one, time).SetEase(ease);
    }

    public void OnDoScaleZero()
    {
        int val = (int)ease;
        Ease ea = (Ease)(val - 1);
        var anim = rect.DOScale(Vector3.zero, time).SetEase(ea);
    }
}
