using UnityEngine;

/// <summary>
/// Handle the projectile launched by the player to fix the robots.
/// </summary>
public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        GameObject player = GameObject.FindWithTag("Player");
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), player.GetComponent<Collider2D>(), true);
    }

    void Update()
    {
        //destroy the projectile when it reach a distance of 1000.0f from the origin
        if(transform.position.magnitude > 1000.0f)
            Destroy(gameObject);
    }

    //called by the player controller after it instantiate a new projectile to launch it.
    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.GetComponent<Enemy>() != null)
        {
            Enemy e = other.collider.GetComponent<Enemy>();
            e.Fix();
        }
        else if(other.collider.GetComponent<boss>() != null) 
        {
            boss b = other.collider.GetComponent<boss>();
            b.Fix();
        }
        
        if(other.collider.tag != "Player")
        {
            Destroy(gameObject);
        }
      
    }
}
