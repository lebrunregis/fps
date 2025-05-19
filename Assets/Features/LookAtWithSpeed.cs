using UnityEngine;

public class LookAtWithSpeed : MonoBehaviour
{
    public Transform target;
    public float speed = 0.5f;
    public float maxDistance = 25;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < maxDistance)
        {
            Quaternion targetRotation = Quaternion.LookRotation(transform.position - target.position, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, speed);
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, transform.parent.rotation, speed);
        }

    }
}
