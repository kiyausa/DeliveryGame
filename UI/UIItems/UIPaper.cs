using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(UI.Input.ButtonManager))]
public class UIPaper : MonoBehaviour, UI.Input.UIButton
{

    [SerializeField] private GameObject target;
    [SerializeField] private GameObject confirm;

    public UnityEvent OnClickDown;

    public UnityEvent OnClickUp;

    private bool entered = false;

    public Color NormalColor { get; set; }
    public Color PressedColor { get; set; }
    public Color SelectedColor { get; set; }

    public void Initialize()
    {
    }

    public void OnValidate()
    {
        Initialize();
    }

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        if (confirm.activeSelf)
        {
            target.SetActive(true);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnClickDown.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (entered) OnClickUp.Invoke();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        entered = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        entered = false;
    }
}
