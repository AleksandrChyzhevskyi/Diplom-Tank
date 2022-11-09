using UnityEngine;

public class MoveTank : MonoBehaviour
{
    private float moveTank, sT1 = 5, sT2 = -5, speed = 20f, turnSpeed = 400f;
    private Rigidbody rb;    
    void Start()
    {
        rb = GetComponent<Rigidbody>();       
    }
    private void FixedUpdate()
    {
        moveTank = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        rb.MovePosition(transform.position + transform.forward * moveTank);
        float turn = Input.GetAxis("Horizontal");
        transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
    }
    private void Update()
    {
        Debug.Log(moveTank);

        if (moveTank > 0 && transform.position.x <= -5)
        {
            this.transform.Rotate(sT2 * Time.deltaTime, 0, 0);            
        }

        if (moveTank == 0)
            this.transform.Rotate(0, 0, 0);

        if (moveTank < 0 && transform.position.x >= 5)
        {
            this.transform.Rotate(sT1 * Time.deltaTime, 0, 0);            
        }
    }
}

