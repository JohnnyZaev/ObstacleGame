using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _score;

    public void AddToScore(string tag)
    {
        if (tag == "Hit") return;
        _score++;
        Debug.Log($"We touched things: {_score} times");
    }
}
