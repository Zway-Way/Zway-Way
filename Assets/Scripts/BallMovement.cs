using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    private float speed = 20;
    private float turnSpeed = 15;
    private float horizontalInput; 
    private float forwardInput;
    private Rigidbody rb;
    public LayerMask groundLayers;
    public float jumpForce = 5;
    public SphereCollider col;
    #region Monobehaviour API

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }

    void Update()
    {
        // Get the horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");

        // Consistently move forward.
        Vector3 moveForward = (Vector3.back * Time.deltaTime * 5);

        // Calculate amount to move horizontally.
        Vector3 moveHorizontally = (Vector3.left * Time.deltaTime * turnSpeed * horizontalInput);

        // Apply calculations to move forward
        move(moveForward);

        // Apply calculations to move horiziontally 
        move(moveHorizontally);

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("I am pressing space");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        bool IsGrounded()
        {
            return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y,
                col.bounds.center.z), col.radius * .9f, groundLayers);
        }

        /**
         * move
         * @param { Vector3 } toApply the calcuations to apply to the position
         * @return { void } 
         */
        void move(Vector3 toApply)
        {
            transform.Translate(toApply);
        }
    }
}
        #endregion
   