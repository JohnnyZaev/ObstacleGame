using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private void Update()
    {
        var xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue, 0, zValue);
    }
}
