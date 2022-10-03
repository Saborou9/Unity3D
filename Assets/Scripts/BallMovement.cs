using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector3(1, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(0, 0, -2));
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(0, 0, 2));
        }
    }
}
