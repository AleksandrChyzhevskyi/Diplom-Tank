using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject vfx;
    public Rigidbody tank, snarad;
    public Transform shootPosition;
    private float snaraadForce = 150f, wait = 0f; 
    
    private void Update()
    {
        wait -= Time.deltaTime;        

        if (Input.GetMouseButtonDown(0) && wait <= 0.5f)
        {
            GameObject explosion = Instantiate(vfx, shootPosition.position, Quaternion.identity);
            Destroy(explosion, 1.2f);
           
            Rigidbody shoot = Instantiate(snarad, shootPosition.position, Quaternion.Euler(90, 0, 0));
            shoot.AddForce(-shootPosition.up * snaraadForce, ForceMode.Impulse);
            tank.AddForce(shootPosition.up * 100f);            
        }
    }    
}
