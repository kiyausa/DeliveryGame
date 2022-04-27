using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIBoard : MonoBehaviour
{
    public UnityEvent StartEvent;

    public GameObject game;

    private void Start()
    {
        StartEvent.Invoke();
        game.SetActive(false);
    }
}
