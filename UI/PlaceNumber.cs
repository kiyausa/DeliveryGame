using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceNumber : MonoBehaviour
{
    [SerializeField] private int number;
    private void OnTriggerEnter(Collider other)
    {
        PlaceManegement.Instance.ChangedPlace(number);
    }
}
