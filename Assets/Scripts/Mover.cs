using UnityEngine;

public class Mover : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(0.01f, 0, 0);
    }
}
