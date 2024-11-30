using UnityEngine;

public class CameraViewDetection : MonoBehaviour
{
    private Camera camera;

    void Start()
    {
        camera = Camera.main;  // Reference to the main camera
    }

    void Update()
    {
        Vector3 viewportPos = camera.WorldToViewportPoint(transform.position);

        // Check if the object is outside the camera's view
        if (viewportPos.x < 0 || viewportPos.x > 1 || viewportPos.y < 0 || viewportPos.y > 1)
        {
            Debug.Log("Object is outside the camera's view.");

            if (viewportPos.x < 0)
            {
                Vector3 newPosition = camera.ViewportToWorldPoint(new Vector3(1, viewportPos.y, viewportPos.z));
                newPosition.z = transform.position.z;
                transform.position = newPosition;
            }
            else if (viewportPos.x > 1)
            {
                Vector3 newPosition = camera.ViewportToWorldPoint(new Vector3(0, viewportPos.y, viewportPos.z));
                newPosition.z = transform.position.z;
                transform.position = newPosition;
            }
        }
        else
        {
            Debug.Log("Object is inside the camera's view.");
        }
    }
}
