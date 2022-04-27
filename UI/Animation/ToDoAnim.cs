using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.InputSystem.Layouts;


public class ToDoAnim : MonoBehaviour
{
    [InputControl(layout = "Button")]
    [SerializeField]
    private string _controlPath;
    public void OnMoveAnimation()
    {
        transform.DOLocalMoveX(3f, 1f);
    }
}
