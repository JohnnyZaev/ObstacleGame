using UnityEngine;

public class Mover : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0.01f, 0, 0);
    }
}
