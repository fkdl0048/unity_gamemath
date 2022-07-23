using UnityEngine;

public class IntegerOverflow : MonoBehaviour
{
    private int _bigNumber = 2147483640;
    void Update()
    {
        Debug.Log(_bigNumber);
        _bigNumber++;
    }
}
