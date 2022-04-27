using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LoadScene : MonoBehaviour
{
    private void Awake()
    {
        SceneLoadManager.Instance.LoadStartScene();
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.yKey.wasPressedThisFrame)
        {
            SceneLoadManager.Instance.LoadOfficeScene();
        }
        if (Keyboard.current.tKey.wasPressedThisFrame)
        {
            SceneLoadManager.Instance.LoadTownScene();
        }
    }
}
