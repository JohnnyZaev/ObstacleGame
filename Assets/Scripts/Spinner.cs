using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private Vector3 rotateAngle = Vector3.up * 0.5f;

    private void Update()
    {
        transform.Rotate(rotateAngle);
    }
}
