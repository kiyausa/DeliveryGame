using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DOTweenAnim : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public UnityEvent OnEnter;

    public UnityEvent OnExit;

    public UnityEvent OnClickDown;
    public UnityEvent OnClickUp;
    public UnityEvent OnClick;

    public UnityEvent OnEnableEvent;

    public UnityEvent OnDisableEvent;

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnEnter.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnExit.Invoke();
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        OnClickDown.Invoke();
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        OnClickUp.Invoke();
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick.Invoke();
    }

    public void OnEnable()
    {
        OnEnableEvent.Invoke();
    }

    public void OnDisable()
    {
        OnDisableEvent.Invoke();
    }
}
