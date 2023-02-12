using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Door door;
    public AudioSource PickupKey;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // Activate the script
            PickupKey.Play();
            door.GetComponent<Door>().locked = false;
            Destroy(gameObject);
        }
    }
}