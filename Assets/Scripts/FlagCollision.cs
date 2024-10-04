using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagCollision : MonoBehaviour
{
    public GameObject levelCompletePanel;
    public PlayerMovement playerController;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && Collectible.collectiblesRemaining == 0)  
        {
            levelCompletePanel.SetActive(true);
            playerController.canMove = false;
            
        } else {
            playerController.canMove = true;
        }
    }
}
