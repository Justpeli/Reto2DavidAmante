using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     // A reference to the Rigidbody component 
    private Rigidbody rb;

    [Tooltip("How fast the ball moves forwards automatically")]
    [Range(0, 10)]
    public float rollSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        // Get access to our Rigidbody component 
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        // Check if we're moving to the side 
        rb.AddForce(0, 0, rollSpeed);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Movement(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Movement(true);
        }
    }
    private void Movement(bool isRight)
    {
        float translation = isRight ? -1.5f : 1.5f;
        if (transform.position.x > 0)
        {
            if (isRight)
            {
                transform.position = transform.position + new Vector3(-1.5f, 0, 0);
            }
        }
        else if (transform.position.x< 0)
        {
            if (!isRight)
            {
                transform.position = transform.position + new Vector3(1.5f, 0, 0);
            }
        }
        else
        {
            transform.position = transform.position + new Vector3(translation, 0, 0);
        }
        
    }
    
}


   
    
