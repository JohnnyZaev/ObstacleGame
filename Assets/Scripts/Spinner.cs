using System;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] Vector3 rotateAngle = Vector3.up * 0.5f;

    private void Update()
    {
        transform.Rotate(rotateAngle);
    }
}
