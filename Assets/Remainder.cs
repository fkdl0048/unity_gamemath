using UnityEngine;

public class Remainder : MonoBehaviour
{
    void Start()
    {
        int temp;

        temp = 63 % 4;
        Debug.Log($"이번 순서는{temp + 1}입니다.");
    }
}
