using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float speed = 20f;
    private float turnSpeed = 15f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        // move the ball forward
        transform.Translate(Vector3.back * Time.deltaTime * 5);
        horizontalInput = Input.GetAxis("Horizontal");
        //forwardInput = Input.GetAxis("Vertical");
        //make use of the vertical code to add a jump mechanic
        //moves the ball forward on vertical axis
        //transform.Rotate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotates the ball on horizontal axis
        transform.Translate(Vector3.left * Time.deltaTime * turnSpeed * horizontalInput);

    }
}

 