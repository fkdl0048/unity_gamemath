using System;
using UnityEngine;

public class Power : MonoBehaviour
{
    void Start()
    {
        Debug.Log($"계산 결과입니다. {Math.Pow(2.5,2)}");
    }
}
