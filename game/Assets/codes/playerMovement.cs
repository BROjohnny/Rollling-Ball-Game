using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody Rb;
    public float fowardForce = 2000f;
    public float sideForce = 2000f;
    // Start is called before the first frame update
    void Start()
    {
        Rb.useGravity = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            Rb.AddForce(sideForce * Time.deltaTime , 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            Rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Rb.position.y < -1f) {
            FindObjectOfType<GameMana>().GameOver();
        }
    }
}
