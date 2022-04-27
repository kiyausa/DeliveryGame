using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManegement : Singleton<PlaceManegement>
{
    [SerializeField] private int place;
    [SerializeField] private bool changed { get; set; }

    public int Place
    {
        get
        {
            return this.place;
        }
        set
        {
            this.place = value;
        }
    }

    public void ChangedPlace(int number)
    {
        Place = number;
    }
}
