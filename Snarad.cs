using UnityEngine;

public class Snarad : MonoBehaviour
{
    public GameObject explosion;
    private float radius = 15.0F;
    private float power = 500.0F;   

    private void OnTriggerEnter(Collider other)
    {       
        
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);        
        foreach (Collider hit in colliders)
        {                      
            if (other.CompareTag("Enemy"))
            {                
                Rigidbody rb = hit.GetComponent<Rigidbody>();                
                if (rb != null)
                    rb.AddExplosionForce(power, transform.position, radius, 3.0F);
            }
        }

        if (other.CompareTag("Graund") || other.CompareTag("Enemy"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
