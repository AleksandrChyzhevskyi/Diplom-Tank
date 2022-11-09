using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform lookAt;
    public Transform camTransform;
    public float distance = 15.0f;

    private const float Y_ANGLE_MIN = -10.0f;
    private const float Y_ANGLE_MAX = 25.0f;
    private const float X_ANGLE_MIN = -100.0f;
    private const float X_ANGLE_MAX = 100.0f;

    private float currentX = 0.0f;
    private float currentY = 0.0f;

    private void Start()
    {
        camTransform = transform;          
    }

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        currentX = Mathf.Clamp(currentX, X_ANGLE_MIN, X_ANGLE_MAX);       
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 2, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);         
    }
}
