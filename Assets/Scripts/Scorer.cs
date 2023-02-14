using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _score;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hit")) return;
        _score++;
        Debug.Log($"We touched things: {_score} times");
    }
}
