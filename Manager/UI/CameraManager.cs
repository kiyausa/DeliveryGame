using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class CameraManager : Singleton<CameraManager>
{
    private bool depth;

    [SerializeField] private Volume volume;
    [SerializeField] private GameObject canvas;

    public GameObject Canvas { get { return this.canvas; } }

    public Volume Volume { get { return this.volume; } }

    public bool Depth { get { return this.depth; } set { this.depth = value; } }

    public void ChangeDepth(string name)
    {
        if (name == "BoardVcam")
        {
            Depth = true;
        }
        if (name == "MainVcam")
        {
            Depth = false;
        }
    }
}
