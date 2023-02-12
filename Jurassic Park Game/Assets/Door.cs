using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string levelToLoad;
    public bool locked = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object has the tag "Player"
        if (other.gameObject.CompareTag("Player") && locked == false)
        {
            // Load the level
            SceneManager.LoadScene(levelToLoad);
        }
    }
}