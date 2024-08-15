using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 2f;

    [SerializeField] private Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        float inputx = Input.GetAxis("Horizontal");
        float inputz = Input.GetAxis("Vertical");

        Vector3 moveDirection = (transform.forward * inputz + transform.right * inputx) * movementSpeed * 100 * Time.deltaTime;
        playerRb.velocity = new(moveDirection.x, playerRb.velocity.y, moveDirection.z);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movementSpeed *= 1.5f;
        }

        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed = 2f;
        }

    }
}
