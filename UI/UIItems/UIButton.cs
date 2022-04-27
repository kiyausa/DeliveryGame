using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(UI.Input.ButtonManager))]
public class UIButton : MonoBehaviour, UI.Input.UIButton
{
    private UIImage image;

    [SerializeField] private Color normal;
    [SerializeField] private Color pressed;
    [SerializeField] private Color selected;

    public Color NormalColor { get => normal; set { normal = value; } }
    public Color PressedColor { get => pressed; set { pressed = value; } }
    public Color SelectedColor { get => selected; set { selected = value; } }

    public UnityEvent OnClickDown;

    public UnityEvent OnClickUp;

    private bool entered = false;

    private bool bpressed = false;

    private void Start()
    {
        image.Color = NormalColor;
    }

    private void FixedUpdate()
    {
    }

    private void Initialize()
    {
        if (this.gameObject.transform.childCount != 0)
            image = this.gameObject.transform.GetChild(1).GetComponent<UIImage>();
    }

    private void OnValidate()
    {
        Initialize();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        bpressed = true;
        SetColor(PressedColor);
        OnClickDown.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        bpressed = false;
        SetColor(NormalColor);
        if (entered) OnClickUp.Invoke();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        entered = true;
        SetColor(SelectedColor);
        Debug.Log("Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        entered = false;
        if (bpressed) SetColor(PressedColor);
        else SetColor(NormalColor);
    }

    private void SetColor(Color color)
    {
        if (this.gameObject.transform.childCount != 0)
            image.Color = color;
    }
}
