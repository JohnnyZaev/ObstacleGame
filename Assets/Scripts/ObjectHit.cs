using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;
        GetComponent<MeshRenderer>().material.color = Color.red;
        collision.gameObject.GetComponent<Scorer>().AddToScore(tag);
        tag = "Hit";
    }
}
