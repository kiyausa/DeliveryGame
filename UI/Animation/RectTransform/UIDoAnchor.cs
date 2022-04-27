using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(DOTweenAnim))]
public class UIAnchor : MonoBehaviour
{
    #region Variable

    [SerializeField]
    float val = 1f;

    [SerializeField]
    float xval = 1f;
    [SerializeField]
    float yval = 1f;
    [SerializeField]
    float zval = 1f;

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

    public void OnDoAnchorMax()
    {
    }
    public void OnDoAnchorMin()
    {
    }
    public void OnDoAnchorPos()
    {
    }
    public void OnDoAnchorPosX()
    {
    }
    public void OnDoAnchorPosY()
    {
    }
    public void OnDoAnchorPos3DX()
    {
    }
    public void OnDoAnchorPos3DY()
    {
    }
    public void OnDoAnchorPos3DZ()
    {
    }
    public void OnDoJumpAnchorPos()
    {
    }
    public void OnDoPunchAnchorPos()
    {
    }
    public void OnDoShakeAnchorPos()
    {
    }
}