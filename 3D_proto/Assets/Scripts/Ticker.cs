using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticker : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        MoveTicker();
    }
    private void MoveTicker()
    {
        Quaternion sinRotation = new();
        transform.rotation = sinRotation;
            //Mathf.Sin
    }
}
