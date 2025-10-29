using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public float speed = 5f;
    public Vector3 offset;

    private void Start()
    {
        if (target == null)
        {
            target = GameObject.FindWithTag("Player");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.fixedDeltaTime * speed);
    }
}
