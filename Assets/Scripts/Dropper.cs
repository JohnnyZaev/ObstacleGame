using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private Rigidbody _rigidbody;
    private float _timeToDrop = 5f;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
        _meshRenderer.enabled = false;
        _rigidbody.useGravity = false;
    }

    private void Update()
    {
        if (!(Time.time > _timeToDrop)) return;
        _meshRenderer.enabled = true;
        _rigidbody.useGravity = true;
    }
}
