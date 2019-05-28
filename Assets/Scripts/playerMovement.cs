using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);

        if (Input.GetKey("d")) {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
