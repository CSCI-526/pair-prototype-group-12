using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject correspondingUIElement; 
    public static int collectiblesRemaining;

    void Start()
    {
        collectiblesRemaining++; 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            gameObject.SetActive(false); 
            correspondingUIElement.SetActive(false); 

            collectiblesRemaining--;
        }
    }
}
