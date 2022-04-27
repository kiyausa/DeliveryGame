using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BoardSystem : MonoBehaviour
{
    [SerializeField] private CinemachineBrain brain;


    private float weight = 0f;

    private void FixedUpdate()
    {
        weight = brain.ActiveBlend.BlendWeight;

        if (weight > 0.99f)
        {
            if (CameraManager.Instance.Depth)
            {
                DepthOfField depth;
                CameraManager.Instance.Volume.profile.TryGet(out depth);
                PlaceManegement.Instance.ChangedPlace(4);
                depth.active = true;
                CameraManager.Instance.Canvas.SetActive(true);
            }
        }
        if (!CameraManager.Instance.Depth)
        {
            DepthOfField depth;
            CameraManager.Instance.Volume.profile.TryGet(out depth);
            PlaceManegement.Instance.ChangedPlace(5);
            depth.active = false;
            CameraManager.Instance.Canvas.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<PlayerMovement>().clickable = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<PlayerMovement>().clickable = 0;
    }

    public void OnChangeCamera(ICinemachineCamera incomingVcam, ICinemachineCamera outgoingVcam)
    {
        CameraManager.Instance.ChangeDepth(incomingVcam.Name);
    }
}
