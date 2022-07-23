using System;
using UnityEngine;

public class RoundNumber : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Math.Round(3.67f, 1));
        Debug.Log(Math.Ceiling(3.67f));
        Debug.Log(Math.Floor(3.67f));
    }
}
