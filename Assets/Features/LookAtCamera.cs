using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Camera _camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.rotation = _camera.transform.rotation;
    }
}
