using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    [SerializeField] private float jumpForce = 100f;
    [SerializeField] private float speed = 2f;
    [SerializeField] private Rigidbody characterBody;
    void Update() 
    {
        if (Input.GetAxis("Horizontal") != 0) //If I press any of the horizontal buttons
        {
            transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal")); 
        }

        if (Input.GetAxis("Vertical") != 0) //If I press any of the vertical buttons
        {
            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical")); 
        }

        if (Input.GetKeyDown(KeyCode.Space) && characterBody.velocity.y <= 0.5f) //Object jumps when pressing Space
        {
            Jump();
        }

    }

    private void Jump()
    {
        characterBody.AddForce(Vector3.up * jumpForce);
    }


}
