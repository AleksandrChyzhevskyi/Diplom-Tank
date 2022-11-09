using UnityEngine;

public class MoveTurell : MonoBehaviour
{
    private Quaternion turell;
    private float horizontalZ;

    private void Start()
    {
        turell = transform.rotation;
    }
    private void Update()
    {
        horizontalZ += Input.GetAxis("Mouse X") * 2;
        horizontalZ = Mathf.Clamp(horizontalZ, -70, 70);
        Quaternion rotationZ = Quaternion.Euler(0, 0, horizontalZ);        
        transform.localRotation = turell * rotationZ;
    }
}
