using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _score;

    public void AddToScore(string gameObjectTag)
    {
        if (gameObjectTag == "Hit") return;
        _score++;
        Debug.Log($"We touched things: {_score} times");
    }
}
