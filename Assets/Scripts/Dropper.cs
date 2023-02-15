using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float dropTime = 5f;
    private MeshRenderer _meshRenderer;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
        _meshRenderer.enabled = false;
        _rigidbody.useGravity = false;
    }

    private void Update()
    {
        if (!(Time.time > dropTime)) return;
        _meshRenderer.enabled = true;
        _rigidbody.useGravity = true;
    }
}
