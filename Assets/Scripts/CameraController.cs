using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject targetPrefab;
    public float speed = 5f;
    public Vector3 offset;
  
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, targetPrefab.transform.position + offset, Time.fixedDeltaTime * speed);
    }
}
