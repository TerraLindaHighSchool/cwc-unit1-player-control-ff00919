using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private float speed = 5.0f;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);    
        transform.Rotate(Vector3.up, horizontalInput *turnSpeed * Time.deltaTime);
    }
}
