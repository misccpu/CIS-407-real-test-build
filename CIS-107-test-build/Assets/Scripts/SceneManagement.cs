using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.CompareTag("Player"))
        {
            // Loading level with build index
            SceneManager.LoadScene(1);

            // Loading level with scene name
            // SceneManager.LoadScene("Battle Scene");
        }
    }
}
