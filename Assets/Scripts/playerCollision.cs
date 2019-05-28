using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) {
        
    //    if (collisionInfo.collider.name.StartsWith("Obstacle")) {
        if (collisionInfo.collider.tag == "Obstacle") {
           movement.enabled = false;
           FindObjectOfType<GameManager>().EndGame();
       }

    }
}
