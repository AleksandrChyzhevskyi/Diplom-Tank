using UnityEngine;

public class MoveGun : MonoBehaviour
{
    private float verticalY;
    private Quaternion gun;

    private void Start()
    {
        gun = transform.localRotation;
    }

    private void Update()
    {        
        verticalY += Input.GetAxis("Mouse Y") * 2;
        verticalY = Mathf.Clamp(verticalY, -15, 30);
        Quaternion rotationY = Quaternion.Euler(-verticalY, 0 ,0); 
        transform.localRotation = gun * rotationY;
    }
}
